﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnmatchpaymentExportFile
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BAACINS")]
	public partial class DataBaseBAACINSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataBaseBAACINSDataContext() : 
				base(global::UnmatchpaymentExportFile.Properties.Settings.Default.BAACINSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseBAACINSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseBAACINSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseBAACINSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseBAACINSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="UP.SP_GLExport")]
		public ISingleResult<SP_GLExportResult> SP_GLExport()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_GLExportResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="UP.SP_SPINExport")]
		public ISingleResult<SP_SPINExportResult> SP_SPINExport()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_SPINExportResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_GLExportResult
	{
		
		private string _FUNCTION_ID;
		
		private string _POSTING_DATE;
		
		private string _REF_LINE;
		
		private string _NEWBS;
		
		private string _WRBTR;
		
		private string _NEWKO;
		
		private string _GSBER;
		
		private string _GSBER1;
		
		private string _KOSTL;
		
		private string _PRCTR;
		
		private string _ZZSUBBOOK;
		
		private string _PRODUCT;
		
		private string _MEMO;
		
		private string _TYPE;
		
		private string _SUBTYPE;
		
		private string _MARKETCODE;
		
		public SP_GLExportResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FUNCTION_ID", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string FUNCTION_ID
		{
			get
			{
				return this._FUNCTION_ID;
			}
			set
			{
				if ((this._FUNCTION_ID != value))
				{
					this._FUNCTION_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POSTING_DATE", DbType="NVarChar(8)")]
		public string POSTING_DATE
		{
			get
			{
				return this._POSTING_DATE;
			}
			set
			{
				if ((this._POSTING_DATE != value))
				{
					this._POSTING_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REF_LINE", DbType="NVarChar(4)")]
		public string REF_LINE
		{
			get
			{
				return this._REF_LINE;
			}
			set
			{
				if ((this._REF_LINE != value))
				{
					this._REF_LINE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NEWBS", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string NEWBS
		{
			get
			{
				return this._NEWBS;
			}
			set
			{
				if ((this._NEWBS != value))
				{
					this._NEWBS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WRBTR", DbType="VarChar(15)")]
		public string WRBTR
		{
			get
			{
				return this._WRBTR;
			}
			set
			{
				if ((this._WRBTR != value))
				{
					this._WRBTR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NEWKO", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string NEWKO
		{
			get
			{
				return this._NEWKO;
			}
			set
			{
				if ((this._NEWKO != value))
				{
					this._NEWKO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GSBER", DbType="NVarChar(50)")]
		public string GSBER
		{
			get
			{
				return this._GSBER;
			}
			set
			{
				if ((this._GSBER != value))
				{
					this._GSBER = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GSBER1", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string GSBER1
		{
			get
			{
				return this._GSBER1;
			}
			set
			{
				if ((this._GSBER1 != value))
				{
					this._GSBER1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOSTL", DbType="NVarChar(10)")]
		public string KOSTL
		{
			get
			{
				return this._KOSTL;
			}
			set
			{
				if ((this._KOSTL != value))
				{
					this._KOSTL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRCTR", DbType="NVarChar(10)")]
		public string PRCTR
		{
			get
			{
				return this._PRCTR;
			}
			set
			{
				if ((this._PRCTR != value))
				{
					this._PRCTR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZZSUBBOOK", DbType="VarChar(6)")]
		public string ZZSUBBOOK
		{
			get
			{
				return this._ZZSUBBOOK;
			}
			set
			{
				if ((this._ZZSUBBOOK != value))
				{
					this._ZZSUBBOOK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRODUCT", DbType="VarChar(4)")]
		public string PRODUCT
		{
			get
			{
				return this._PRODUCT;
			}
			set
			{
				if ((this._PRODUCT != value))
				{
					this._PRODUCT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MEMO", DbType="VarChar(30)")]
		public string MEMO
		{
			get
			{
				return this._MEMO;
			}
			set
			{
				if ((this._MEMO != value))
				{
					this._MEMO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TYPE", DbType="VarChar(4)")]
		public string TYPE
		{
			get
			{
				return this._TYPE;
			}
			set
			{
				if ((this._TYPE != value))
				{
					this._TYPE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUBTYPE", DbType="VarChar(5)")]
		public string SUBTYPE
		{
			get
			{
				return this._SUBTYPE;
			}
			set
			{
				if ((this._SUBTYPE != value))
				{
					this._SUBTYPE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MARKETCODE", DbType="VarChar(4)")]
		public string MARKETCODE
		{
			get
			{
				return this._MARKETCODE;
			}
			set
			{
				if ((this._MARKETCODE != value))
				{
					this._MARKETCODE = value;
				}
			}
		}
	}
	
	public partial class SP_SPINExportResult
	{
		
		private string _RECORD_TYPE;
		
		private string _SEQUENCE_NO;
		
		private string _BANK_CODE;
		
		private string _COMPANY_ACCOUNT_NO;
		
		private string _COMPANY_NAME;
		
		private string _POST_DATE;
		
		private string _FILLER;
		
		public SP_SPINExportResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECORD_TYPE", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string RECORD_TYPE
		{
			get
			{
				return this._RECORD_TYPE;
			}
			set
			{
				if ((this._RECORD_TYPE != value))
				{
					this._RECORD_TYPE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SEQUENCE_NO", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string SEQUENCE_NO
		{
			get
			{
				return this._SEQUENCE_NO;
			}
			set
			{
				if ((this._SEQUENCE_NO != value))
				{
					this._SEQUENCE_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BANK_CODE", DbType="VarChar(3) NOT NULL", CanBeNull=false)]
		public string BANK_CODE
		{
			get
			{
				return this._BANK_CODE;
			}
			set
			{
				if ((this._BANK_CODE != value))
				{
					this._BANK_CODE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPANY_ACCOUNT_NO", DbType="VarChar(12)")]
		public string COMPANY_ACCOUNT_NO
		{
			get
			{
				return this._COMPANY_ACCOUNT_NO;
			}
			set
			{
				if ((this._COMPANY_ACCOUNT_NO != value))
				{
					this._COMPANY_ACCOUNT_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPANY_NAME", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string COMPANY_NAME
		{
			get
			{
				return this._COMPANY_NAME;
			}
			set
			{
				if ((this._COMPANY_NAME != value))
				{
					this._COMPANY_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POST_DATE", DbType="VarChar(8)")]
		public string POST_DATE
		{
			get
			{
				return this._POST_DATE;
			}
			set
			{
				if ((this._POST_DATE != value))
				{
					this._POST_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FILLER", DbType="VarChar(79)")]
		public string FILLER
		{
			get
			{
				return this._FILLER;
			}
			set
			{
				if ((this._FILLER != value))
				{
					this._FILLER = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
