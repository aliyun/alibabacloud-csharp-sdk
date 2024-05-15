// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the default version.
        /// </summary>
        [NameInMap("DefaultVersion")]
        [Validation(Required=false)]
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// Specifies whether to query the configurations of the launch template. Valid values:
        /// 
        /// *   true: queries the basic information and other details of the launch template. The details include the image ID and system disk size.
        /// *   false: queries only the basic information of the launch template. The basic information includes the template ID, template name, and default version.
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("DetailFlag")]
        [Validation(Required=false)]
        public bool? DetailFlag { get; set; }

        /// <summary>
        /// The ID of the launch template.
        /// 
        /// You must set LaunchTemplateId or LaunchTemplateName to specify a launch template.
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// The name of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Version N of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public List<long?> LaunchTemplateVersion { get; set; }

        /// <summary>
        /// The maximum version number in the version range to query.
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

        /// <summary>
        /// The minimum version number in the version range to query.
        /// </summary>
        [NameInMap("MinVersion")]
        [Validation(Required=false)]
        public long? MinVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the launch template.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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

    }

}
