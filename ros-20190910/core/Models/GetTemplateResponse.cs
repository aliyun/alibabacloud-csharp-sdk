// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=true)]
        public string TemplateBody { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=true)]
        public string StackId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=true)]
        public string TemplateId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=true)]
        public string StackGroupName { get; set; }

        [NameInMap("ChangeSetId")]
        [Validation(Required=true)]
        public string ChangeSetId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=true)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=true)]
        public string Description { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=true)]
        public string TemplateName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=true)]
        public string UpdateTime { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=true)]
        public string TemplateVersion { get; set; }

        [NameInMap("ShareType")]
        [Validation(Required=true)]
        public string ShareType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=true)]
        public string OwnerId { get; set; }

        [NameInMap("TemplateARN")]
        [Validation(Required=true)]
        public string TemplateARN { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=true)]
        public List<GetTemplateResponsePermissions> Permissions { get; set; }
        public class GetTemplateResponsePermissions : TeaModel {
            [NameInMap("ShareOption")]
            [Validation(Required=true)]
            public string ShareOption { get; set; }

            [NameInMap("VersionOption")]
            [Validation(Required=true)]
            public string VersionOption { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=true)]
            public string TemplateVersion { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public string AccountId { get; set; }

        }

    }

}
