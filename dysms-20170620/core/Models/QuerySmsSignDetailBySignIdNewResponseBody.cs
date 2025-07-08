// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSignDetailBySignIdNewResponseBody : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("ApplicationScene")]
        [Validation(Required=false)]
        public QuerySmsSignDetailBySignIdNewResponseBodyApplicationScene ApplicationScene { get; set; }
        public class QuerySmsSignDetailBySignIdNewResponseBodyApplicationScene : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

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
        public string AuthorizationLetterId { get; set; }

        [NameInMap("AuthorizationLetterName")]
        [Validation(Required=false)]
        public string AuthorizationLetterName { get; set; }

        [NameInMap("AuthorizationLetterState")]
        [Validation(Required=false)]
        public string AuthorizationLetterState { get; set; }

        [NameInMap("AuthorizationLetterStatus")]
        [Validation(Required=false)]
        public string AuthorizationLetterStatus { get; set; }

        [NameInMap("AuthorizationSignScope")]
        [Validation(Required=false)]
        public string AuthorizationSignScope { get; set; }

        [NameInMap("EffectSceneType")]
        [Validation(Required=false)]
        public int? EffectSceneType { get; set; }

        [NameInMap("EnableAuthorizationLetter")]
        [Validation(Required=false)]
        public bool? EnableAuthorizationLetter { get; set; }

        [NameInMap("ExtendMessage")]
        [Validation(Required=false)]
        public string ExtendMessage { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public List<long?> FileIds { get; set; }

        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public List<string> FileUrlList { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

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

        [NameInMap("IsSignScopeOCRDiff")]
        [Validation(Required=false)]
        public bool? IsSignScopeOCRDiff { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QuerySmsSignDetailBySignIdNewResponseBodyList> List { get; set; }
        public class QuerySmsSignDetailBySignIdNewResponseBodyList : TeaModel {
            [NameInMap("AuditState")]
            [Validation(Required=false)]
            public string AuditState { get; set; }

            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public int? SceneType { get; set; }

        }

        [NameInMap("NeedAuthorized")]
        [Validation(Required=false)]
        public bool? NeedAuthorized { get; set; }

        [NameInMap("OpenTag")]
        [Validation(Required=false)]
        public bool? OpenTag { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("OssKeys")]
        [Validation(Required=false)]
        public List<string> OssKeys { get; set; }

        [NameInMap("ProxyAuthorization")]
        [Validation(Required=false)]
        public string ProxyAuthorization { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("SignScopeOCR")]
        [Validation(Required=false)]
        public string SignScopeOCR { get; set; }

        [NameInMap("SignUpgrade")]
        [Validation(Required=false)]
        public string SignUpgrade { get; set; }

    }

}
