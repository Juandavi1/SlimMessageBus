// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Sample.Serialization.MessagesAvro
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class AddCommand : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"AddCommand\",\"namespace\":\"Sample.Serialization.MessagesAv" +
				"ro\",\"fields\":[{\"name\":\"OperationId\",\"type\":\"string\"},{\"name\":\"Left\",\"type\":\"int\"" +
				"},{\"name\":\"Right\",\"type\":\"int\"}]}");
		private string _OperationId;
		private int _Left;
		private int _Right;
		public virtual Schema Schema
		{
			get
			{
				return AddCommand._SCHEMA;
			}
		}
		public string OperationId
		{
			get
			{
				return this._OperationId;
			}
			set
			{
				this._OperationId = value;
			}
		}
		public int Left
		{
			get
			{
				return this._Left;
			}
			set
			{
				this._Left = value;
			}
		}
		public int Right
		{
			get
			{
				return this._Right;
			}
			set
			{
				this._Right = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.OperationId;
			case 1: return this.Left;
			case 2: return this.Right;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.OperationId = (System.String)fieldValue; break;
			case 1: this.Left = (System.Int32)fieldValue; break;
			case 2: this.Right = (System.Int32)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
