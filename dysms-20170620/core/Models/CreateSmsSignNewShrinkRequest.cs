// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class CreateSmsSignNewShrinkRequest : TeaModel {
        [NameInMap("ApplicationSceneId")]
        [Validation(Required=false)]
        public long? ApplicationSceneId { get; set; }

        [NameInMap("ApplySource")]
        [Validation(Required=false)]
        public string ApplySource { get; set; }

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

        [NameInMap("AuthorizationSignScope")]
        [Validation(Required=false)]
        public string AuthorizationSignScope { get; set; }

        [NameInMap("CreateSignGray")]
        [Validation(Required=false)]
        public bool? CreateSignGray { get; set; }

        [NameInMap("EnableAuthorizationLetter")]
        [Validation(Required=false)]
        public bool? EnableAuthorizationLetter { get; set; }

        [NameInMap("ExtendMessage")]
        [Validation(Required=false)]
        public string ExtendMessage { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        [NameInMap("IsAuthorizationLetterOCRComplete")]
        [Validation(Required=false)]
        public bool? IsAuthorizationLetterOCRComplete { get; set; }

        [NameInMap("IsAuthorizationLetterOCRDiff")]
        [Validation(Required=false)]
        public bool? IsAuthorizationLetterOCRDiff { get; set; }

        [NameInMap("IsSignScopeOCRDiff")]
        [Validation(Required=false)]
        public bool? IsSignScopeOCRDiff { get; set; }

        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("OssKeys")]
        [Validation(Required=false)]
        public string OssKeys { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ProxyAuthorization")]
        [Validation(Required=false)]
        public string ProxyAuthorization { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        [NameInMap("QualificationType")]
        [Validation(Required=false)]
        public long? QualificationType { get; set; }

        [NameInMap("QualificationVersion")]
        [Validation(Required=false)]
        public long? QualificationVersion { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public int? ServiceType { get; set; }

        [NameInMap("SignCode")]
        [Validation(Required=false)]
        public string SignCode { get; set; }

        [NameInMap("SignId")]
        [Validation(Required=false)]
        public string SignId { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignScopeOCR")]
        [Validation(Required=false)]
        public string SignScopeOCR { get; set; }

        [NameInMap("SignUpgrade")]
        [Validation(Required=false)]
        public bool? SignUpgrade { get; set; }

        [NameInMap("ThirdParty")]
        [Validation(Required=false)]
        public bool? ThirdParty { get; set; }

        [NameInMap("UserViewFileName")]
        [Validation(Required=false)]
        public string UserViewFileName { get; set; }

    }

}
