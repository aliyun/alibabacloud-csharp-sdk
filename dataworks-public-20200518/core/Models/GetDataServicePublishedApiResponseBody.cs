// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServicePublishedApiResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServicePublishedApiResponseBodyData Data { get; set; }
        public class GetDataServicePublishedApiResponseBodyData : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            [NameInMap("ApiMode")]
            [Validation(Required=false)]
            public int? ApiMode { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("ApiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("Protocols")]
            [Validation(Required=false)]
            public List<int?> Protocols { get; set; }

            [NameInMap("RegistrationDetails")]
            [Validation(Required=false)]
            public GetDataServicePublishedApiResponseBodyDataRegistrationDetails RegistrationDetails { get; set; }
            public class GetDataServicePublishedApiResponseBodyDataRegistrationDetails : TeaModel {
                [NameInMap("FailedResultSample")]
                [Validation(Required=false)]
                public string FailedResultSample { get; set; }

                [NameInMap("RegistrationErrorCodes")]
                [Validation(Required=false)]
                public List<GetDataServicePublishedApiResponseBodyDataRegistrationDetailsRegistrationErrorCodes> RegistrationErrorCodes { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataRegistrationDetailsRegistrationErrorCodes : TeaModel {
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
                public List<GetDataServicePublishedApiResponseBodyDataRegistrationDetailsRegistrationRequestParameters> RegistrationRequestParameters { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataRegistrationDetailsRegistrationRequestParameters : TeaModel {
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

            [NameInMap("RequestMethod")]
            [Validation(Required=false)]
            public int? RequestMethod { get; set; }

            [NameInMap("ResponseContentType")]
            [Validation(Required=false)]
            public int? ResponseContentType { get; set; }

            [NameInMap("ScriptDetails")]
            [Validation(Required=false)]
            public GetDataServicePublishedApiResponseBodyDataScriptDetails ScriptDetails { get; set; }
            public class GetDataServicePublishedApiResponseBodyDataScriptDetails : TeaModel {
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
                public GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptConnection ScriptConnection { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptConnection : TeaModel {
                    [NameInMap("ConnectionId")]
                    [Validation(Required=false)]
                    public long? ConnectionId { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                [NameInMap("ScriptErrorCodes")]
                [Validation(Required=false)]
                public List<GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptErrorCodes> ScriptErrorCodes { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptErrorCodes : TeaModel {
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
                public List<GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptRequestParameters> ScriptRequestParameters { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptRequestParameters : TeaModel {
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
                public List<GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptResponseParameters> ScriptResponseParameters { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataScriptDetailsScriptResponseParameters : TeaModel {
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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("VisibleRange")]
            [Validation(Required=false)]
            public int? VisibleRange { get; set; }

            [NameInMap("WizardDetails")]
            [Validation(Required=false)]
            public GetDataServicePublishedApiResponseBodyDataWizardDetails WizardDetails { get; set; }
            public class GetDataServicePublishedApiResponseBodyDataWizardDetails : TeaModel {
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
                public GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardConnection WizardConnection { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardConnection : TeaModel {
                    [NameInMap("ConnectionId")]
                    [Validation(Required=false)]
                    public long? ConnectionId { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                [NameInMap("WizardErrorCodes")]
                [Validation(Required=false)]
                public List<GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardErrorCodes> WizardErrorCodes { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardErrorCodes : TeaModel {
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
                public List<GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardRequestParameters> WizardRequestParameters { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardRequestParameters : TeaModel {
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
                public List<GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardResponseParameters> WizardResponseParameters { get; set; }
                public class GetDataServicePublishedApiResponseBodyDataWizardDetailsWizardResponseParameters : TeaModel {
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
