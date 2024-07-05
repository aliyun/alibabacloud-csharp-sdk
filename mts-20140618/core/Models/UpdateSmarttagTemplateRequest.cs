// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateSmarttagTemplateRequest : TeaModel {
        [NameInMap("AnalyseTypes")]
        [Validation(Required=false)]
        public string AnalyseTypes { get; set; }

        [NameInMap("FaceCategoryIds")]
        [Validation(Required=false)]
        public string FaceCategoryIds { get; set; }

        [NameInMap("FaceCustomParamsConfig")]
        [Validation(Required=false)]
        public string FaceCustomParamsConfig { get; set; }

        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("KeywordConfig")]
        [Validation(Required=false)]
        public string KeywordConfig { get; set; }

        [NameInMap("KnowledgeConfig")]
        [Validation(Required=false)]
        public string KnowledgeConfig { get; set; }

        [NameInMap("LabelType")]
        [Validation(Required=false)]
        public string LabelType { get; set; }

        [NameInMap("LabelVersion")]
        [Validation(Required=false)]
        public string LabelVersion { get; set; }

        [NameInMap("LandmarkGroupIds")]
        [Validation(Required=false)]
        public string LandmarkGroupIds { get; set; }

        [NameInMap("ObjectGroupIds")]
        [Validation(Required=false)]
        public string ObjectGroupIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
