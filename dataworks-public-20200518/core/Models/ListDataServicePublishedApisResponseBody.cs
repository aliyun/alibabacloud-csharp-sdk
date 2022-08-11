// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServicePublishedApisResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataServicePublishedApisResponseBodyData Data { get; set; }
        public class ListDataServicePublishedApisResponseBodyData : TeaModel {
            [NameInMap("Apis")]
            [Validation(Required=false)]
            public List<ListDataServicePublishedApisResponseBodyDataApis> Apis { get; set; }
            public class ListDataServicePublishedApisResponseBodyDataApis : TeaModel {
                public long? ApiId { get; set; }
                public int? ApiMode { get; set; }
                public string ApiName { get; set; }
                public string ApiPath { get; set; }
                public string CreatedTime { get; set; }
                public string CreatorId { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string ModifiedTime { get; set; }
                public string OperatorId { get; set; }
                public long? ProjectId { get; set; }
                public List<int?> Protocols { get; set; }
                public ListDataServicePublishedApisResponseBodyDataApisRegistrationDetails RegistrationDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetails : TeaModel {
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    [NameInMap("RegistrationErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes> RegistrationErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationErrorCodes : TeaModel {
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
                    public List<ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters> RegistrationRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisRegistrationDetailsRegistrationRequestParameters : TeaModel {
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
                public ListDataServicePublishedApisResponseBodyDataApisScriptDetails ScriptDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisScriptDetails : TeaModel {
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    [NameInMap("Script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    [NameInMap("ScriptConnection")]
                    [Validation(Required=false)]
                    public ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptConnection ScriptConnection { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptConnection : TeaModel {
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }
                    };

                    [NameInMap("ScriptErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptErrorCodes> ScriptErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptErrorCodes : TeaModel {
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

                    [NameInMap("ScriptRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptRequestParameters> ScriptRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptRequestParameters : TeaModel {
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
                    public List<ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptResponseParameters> ScriptResponseParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisScriptDetailsScriptResponseParameters : TeaModel {
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

                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                }
                public int? Status { get; set; }
                public long? TenantId { get; set; }
                public int? Timeout { get; set; }
                public int? VisibleRange { get; set; }
                public ListDataServicePublishedApisResponseBodyDataApisWizardDetails WizardDetails { get; set; }
                public class ListDataServicePublishedApisResponseBodyDataApisWizardDetails : TeaModel {
                    [NameInMap("FailedResultSample")]
                    [Validation(Required=false)]
                    public string FailedResultSample { get; set; }

                    [NameInMap("IsPagedResponse")]
                    [Validation(Required=false)]
                    public bool? IsPagedResponse { get; set; }

                    [NameInMap("SuccessfulResultSample")]
                    [Validation(Required=false)]
                    public string SuccessfulResultSample { get; set; }

                    [NameInMap("WizardConnection")]
                    [Validation(Required=false)]
                    public ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardConnection WizardConnection { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardConnection : TeaModel {
                        [NameInMap("ConnectionId")]
                        [Validation(Required=false)]
                        public long? ConnectionId { get; set; }
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }
                    };

                    [NameInMap("WizardErrorCodes")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardErrorCodes> WizardErrorCodes { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardErrorCodes : TeaModel {
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

                    [NameInMap("WizardRequestParameters")]
                    [Validation(Required=false)]
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardRequestParameters> WizardRequestParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardRequestParameters : TeaModel {
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
                    public List<ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardResponseParameters> WizardResponseParameters { get; set; }
                    public class ListDataServicePublishedApisResponseBodyDataApisWizardDetailsWizardResponseParameters : TeaModel {
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
