// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSignListNewResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsSign")]
        [Validation(Required=false)]
        public QuerySmsSignListNewResponseBodySmsSign SmsSign { get; set; }
        public class QuerySmsSignListNewResponseBodySmsSign : TeaModel {
            [NameInMap("SmsSign")]
            [Validation(Required=false)]
            public List<QuerySmsSignListNewResponseBodySmsSignSmsSign> SmsSign { get; set; }
            public class QuerySmsSignListNewResponseBodySmsSignSmsSign : TeaModel {
                [NameInMap("AggregatedRegisterStatus")]
                [Validation(Required=false)]
                public int? AggregatedRegisterStatus { get; set; }

                [NameInMap("ApplySource")]
                [Validation(Required=false)]
                public string ApplySource { get; set; }

                [NameInMap("AuditInfo")]
                [Validation(Required=false)]
                public string AuditInfo { get; set; }

                [NameInMap("AuditRemarkInfo")]
                [Validation(Required=false)]
                public string AuditRemarkInfo { get; set; }

                [NameInMap("AuditState")]
                [Validation(Required=false)]
                public string AuditState { get; set; }

                [NameInMap("Authorization")]
                [Validation(Required=false)]
                public string Authorization { get; set; }

                [NameInMap("AuthorizationEffTime")]
                [Validation(Required=false)]
                public string AuthorizationEffTime { get; set; }

                [NameInMap("AuthorizationLetter")]
                [Validation(Required=false)]
                public string AuthorizationLetter { get; set; }

                [NameInMap("AuthorizationLetterAuditPass")]
                [Validation(Required=false)]
                public bool? AuthorizationLetterAuditPass { get; set; }

                [NameInMap("AuthorizationLetterId")]
                [Validation(Required=false)]
                public long? AuthorizationLetterId { get; set; }

                [NameInMap("AuthorizationLetterName")]
                [Validation(Required=false)]
                public string AuthorizationLetterName { get; set; }

                [NameInMap("AuthorizationLetterStatus")]
                [Validation(Required=false)]
                public string AuthorizationLetterStatus { get; set; }

                [NameInMap("AuthorizationSignScope")]
                [Validation(Required=false)]
                public string AuthorizationSignScope { get; set; }

                [NameInMap("CanRegister")]
                [Validation(Required=false)]
                public bool? CanRegister { get; set; }

                [NameInMap("EnableAuthorizationLetter")]
                [Validation(Required=false)]
                public bool? EnableAuthorizationLetter { get; set; }

                [NameInMap("ExtendMessage")]
                [Validation(Required=false)]
                public string ExtendMessage { get; set; }

                [NameInMap("FileIds")]
                [Validation(Required=false)]
                public QuerySmsSignListNewResponseBodySmsSignSmsSignFileIds FileIds { get; set; }
                public class QuerySmsSignListNewResponseBodySmsSignSmsSignFileIds : TeaModel {
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public List<long?> FileId { get; set; }

                }

                [NameInMap("FileUrlList")]
                [Validation(Required=false)]
                public QuerySmsSignListNewResponseBodySmsSignSmsSignFileUrlList FileUrlList { get; set; }
                public class QuerySmsSignListNewResponseBodySmsSignSmsSignFileUrlList : TeaModel {
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public List<string> FileUrl { get; set; }

                }

                [NameInMap("GmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsAuthorizationLetterOCRComplete")]
                [Validation(Required=false)]
                public bool? IsAuthorizationLetterOCRComplete { get; set; }

                [NameInMap("IsAuthorizationLetterOCRDiff")]
                [Validation(Required=false)]
                public bool? IsAuthorizationLetterOCRDiff { get; set; }

                [NameInMap("IsDefaultSign")]
                [Validation(Required=false)]
                public bool? IsDefaultSign { get; set; }

                [NameInMap("IsSignScopeOCRDiff")]
                [Validation(Required=false)]
                public bool? IsSignScopeOCRDiff { get; set; }

                [NameInMap("MobileRegisterStatus")]
                [Validation(Required=false)]
                public int? MobileRegisterStatus { get; set; }

                [NameInMap("OperateDateStr")]
                [Validation(Required=false)]
                public string OperateDateStr { get; set; }

                [NameInMap("OrderCount")]
                [Validation(Required=false)]
                public long? OrderCount { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrganizationCode")]
                [Validation(Required=false)]
                public string OrganizationCode { get; set; }

                [NameInMap("ProxyAuthorization")]
                [Validation(Required=false)]
                public string ProxyAuthorization { get; set; }

                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public long? QualificationId { get; set; }

                [NameInMap("QualificationName")]
                [Validation(Required=false)]
                public string QualificationName { get; set; }

                [NameInMap("QualificationState")]
                [Validation(Required=false)]
                public string QualificationState { get; set; }

                [NameInMap("QualificationVersion")]
                [Validation(Required=false)]
                public long? QualificationVersion { get; set; }

                [NameInMap("QualificationWorkOrderId")]
                [Validation(Required=false)]
                public long? QualificationWorkOrderId { get; set; }

                [NameInMap("RegisterResult")]
                [Validation(Required=false)]
                public int? RegisterResult { get; set; }

                [NameInMap("RegisterTime")]
                [Validation(Required=false)]
                public long? RegisterTime { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResultReason")]
                [Validation(Required=false)]
                public string ResultReason { get; set; }

                [NameInMap("SceneType")]
                [Validation(Required=false)]
                public int? SceneType { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

                [NameInMap("SignCode")]
                [Validation(Required=false)]
                public string SignCode { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("SignSceneDetailList")]
                [Validation(Required=false)]
                public QuerySmsSignListNewResponseBodySmsSignSmsSignSignSceneDetailList SignSceneDetailList { get; set; }
                public class QuerySmsSignListNewResponseBodySmsSignSmsSignSignSceneDetailList : TeaModel {
                    [NameInMap("SignSceneDetail")]
                    [Validation(Required=false)]
                    public List<QuerySmsSignListNewResponseBodySmsSignSmsSignSignSceneDetailListSignSceneDetail> SignSceneDetail { get; set; }
                    public class QuerySmsSignListNewResponseBodySmsSignSmsSignSignSceneDetailListSignSceneDetail : TeaModel {
                        [NameInMap("AuditState")]
                        [Validation(Required=false)]
                        public string AuditState { get; set; }

                        [NameInMap("SceneType")]
                        [Validation(Required=false)]
                        public int? SceneType { get; set; }

                    }

                }

                [NameInMap("SignScopeOCR")]
                [Validation(Required=false)]
                public string SignScopeOCR { get; set; }

                [NameInMap("SignSource")]
                [Validation(Required=false)]
                public string SignSource { get; set; }

                [NameInMap("SignType")]
                [Validation(Required=false)]
                public int? SignType { get; set; }

                [NameInMap("TelecomRegisterStatus")]
                [Validation(Required=false)]
                public int? TelecomRegisterStatus { get; set; }

                [NameInMap("UnicomRegisterStatus")]
                [Validation(Required=false)]
                public int? UnicomRegisterStatus { get; set; }

            }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
