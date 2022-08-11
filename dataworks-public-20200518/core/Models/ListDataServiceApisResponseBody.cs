// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceApisResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServiceApisResponseBodyData Data { get; set; }
        public class ListDataServiceApisResponseBodyData : TeaModel {
            [NameInMap("Apis")]
            [Validation(Required=false)]
            public List<ListDataServiceApisResponseBodyDataApis> Apis { get; set; }
            public class ListDataServiceApisResponseBodyDataApis : TeaModel {
                public long? ApiId { get; set; }
                public int? ApiMode { get; set; }
                public string ApiName { get; set; }
                public string ApiPath { get; set; }
                public string CreatedTime { get; set; }
                public string CreatorId { get; set; }
                public string Description { get; set; }
                public long? FolderId { get; set; }
                public string GroupId { get; set; }
                public string ModifiedTime { get; set; }
                public string OperatorId { get; set; }
                public long? ProjectId { get; set; }
                public List<int?> Protocols { get; set; }
                public ListDataServiceApisResponseBodyDataApisRegistrationDetails RegistrationDetails { get; set; }
                public class ListDataServiceApisResponseBodyDataApisRegistrationDetails : TeaModel {
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    [NameInMap("RegistrationErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes> RegistrationErrorCodes { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        [NameInMap("ErrorSolution")]
                        [Validation(Required=false)]
                        public string ErrorSolution { get; set; }

                    }

                    [NameInMap("RegistrationRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters> RegistrationRequestParameters { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters : TeaModel {
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    [NameInMap("ServiceContentType")]
                    [Validation(Required=false)]
                    public int? ServiceContentType { get; set; }

                    [NameInMap("ServiceHost")]
                    [Validation(Required=false)]
                    public string ServiceHost { get; set; }

                    [NameInMap("ServicePath")]
                    [Validation(Required=false)]
                    public string ServicePath { get; set; }

                    [NameInMap("ServiceRequestBodyDescription")]
                    [Validation(Required=false)]
                    public string ServiceRequestBodyDescription { get; set; }

                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                }
                public int? RequestMethod { get; set; }
                public int? ResponseContentType { get; set; }
                public ListDataServiceApisResponseBodyDataApisScriptDetails ScriptDetails { get; set; }
                public class ListDataServiceApisResponseBodyDataApisScriptDetails : TeaModel {
                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    [NameInMap("ScriptConnection")]
                    [Validation(Required=false)]
                    public ListDataServiceApisResponseBodyDataApisScriptDetailsScriptConnection ScriptConnection { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisScriptDetailsScriptConnection : TeaModel {
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }
                    };

                    [NameInMap("ScriptRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisScriptDetailsScriptRequestParameters> ScriptRequestParameters { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisScriptDetailsScriptRequestParameters : TeaModel {
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    [NameInMap("ScriptResponseParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisScriptDetailsScriptResponseParameters> ScriptResponseParameters { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisScriptDetailsScriptResponseParameters : TeaModel {
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                    }

                }
                public int? Status { get; set; }
                public long? TenantId { get; set; }
                public int? Timeout { get; set; }
                public int? VisibleRange { get; set; }
                public ListDataServiceApisResponseBodyDataApisWizardDetails WizardDetails { get; set; }
                public class ListDataServiceApisResponseBodyDataApisWizardDetails : TeaModel {
                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    [NameInMap("WizardConnection")]
                    [Validation(Required=false)]
                    public ListDataServiceApisResponseBodyDataApisWizardDetailsWizardConnection WizardConnection { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisWizardDetailsWizardConnection : TeaModel {
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }
                    };

                    [NameInMap("WizardRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisWizardDetailsWizardRequestParameters> WizardRequestParameters { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisWizardDetailsWizardRequestParameters : TeaModel {
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        [NameInMap("IsRequiredParameter")]
                        [Validation(Required=false)]
                        public bool? IsRequiredParameter { get; set; }

                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                        [NameInMap("ParameterOperator")]
                        [Validation(Required=false)]
                        public int? ParameterOperator { get; set; }

                        [NameInMap("ParameterPosition")]
                        [Validation(Required=false)]
                        public int? ParameterPosition { get; set; }

                    }

                    [NameInMap("WizardResponseParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServiceApisResponseBodyDataApisWizardDetailsWizardResponseParameters> WizardResponseParameters { get; set; }
                    public class ListDataServiceApisResponseBodyDataApisWizardDetailsWizardResponseParameters : TeaModel {
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("ExampleValue")]
                        [Validation(Required=false)]
                        public string ExampleValue { get; set; }

                        [NameInMap("ParameterDataType")]
                        [Validation(Required=false)]
                        public int? ParameterDataType { get; set; }

                        [NameInMap("ParameterDescription")]
                        [Validation(Required=false)]
                        public string ParameterDescription { get; set; }

                        [NameInMap("ParameterName")]
                        [Validation(Required=false)]
                        public string ParameterName { get; set; }

                    }

                }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
