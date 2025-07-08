// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class BatchCreateSmsSignRequest : TeaModel {
        [NameInMap("ColumnIndexMappingRule")]
        [Validation(Required=false)]
        public BatchCreateSmsSignRequestColumnIndexMappingRule ColumnIndexMappingRule { get; set; }
        public class BatchCreateSmsSignRequestColumnIndexMappingRule : TeaModel {
            [NameInMap("AdminIdentifiedNumber")]
            [Validation(Required=false)]
            public int? AdminIdentifiedNumber { get; set; }

            [NameInMap("AdminName")]
            [Validation(Required=false)]
            public int? AdminName { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public int? CompanyName { get; set; }

            [NameInMap("LegalPersonIdentifiedNumber")]
            [Validation(Required=false)]
            public int? LegalPersonIdentifiedNumber { get; set; }

            [NameInMap("LegalPersonName")]
            [Validation(Required=false)]
            public int? LegalPersonName { get; set; }

            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public int? OrganizationCode { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public int? Remark { get; set; }

            [NameInMap("SceneDescription")]
            [Validation(Required=false)]
            public int? SceneDescription { get; set; }

            [NameInMap("SignatureName")]
            [Validation(Required=false)]
            public int? SignatureName { get; set; }

            [NameInMap("SignatureSource")]
            [Validation(Required=false)]
            public int? SignatureSource { get; set; }

            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public int? TemplateContent { get; set; }

        }

        [NameInMap("ExtendMessage")]
        [Validation(Required=false)]
        public string ExtendMessage { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public List<string> MoreData { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        [NameInMap("OssKeys")]
        [Validation(Required=false)]
        public string OssKeys { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SignOssKey")]
        [Validation(Required=false)]
        public string SignOssKey { get; set; }

        [NameInMap("UserViewFileName")]
        [Validation(Required=false)]
        public string UserViewFileName { get; set; }

    }

}
