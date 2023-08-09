// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesRequest : TeaModel {
        /// <summary>
        /// The IDs of launch templates. You can specify up to 100 launch template IDs. You must specify LaunchTemplateId or LaunchTemplateName to determine a launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateId { get; set; }

        /// <summary>
        /// The names of launch templates. You can specify up to 100 launch template names.
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the resource group to which the launch template belongs. If you specify this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be returned.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of whether you specify this parameter.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The tags of the launch template.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of launch templates. You can specify up to 100 launch template IDs. You must specify LaunchTemplateId or LaunchTemplateName to determine a launch template.
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// The tag of the launch template.
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<DescribeLaunchTemplatesRequestTemplateTag> TemplateTag { get; set; }
        public class DescribeLaunchTemplatesRequestTemplateTag : TeaModel {
            /// <summary>
            /// The value of tag N of the launch template. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The number of the page to return. Pages start from page 1.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
