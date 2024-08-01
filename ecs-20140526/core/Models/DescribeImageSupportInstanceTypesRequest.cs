// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesRequest : TeaModel {
        /// <summary>
        /// The scenario in which you want to use the image. Valid values:
        /// 
        /// - CreateEcs (default): instance creation
        /// - ChangeOS: replacement of the system disk or operating system
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// The number of vCPUs of the instance type.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeImageSupportInstanceTypesRequestFilter> Filter { get; set; }
        public class DescribeImageSupportInstanceTypesRequestFilter : TeaModel {
            /// <summary>
            /// Filter N used to filter instance types.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The region ID of the image. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Details about the instance types that are supported by the image.
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
