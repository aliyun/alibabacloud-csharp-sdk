// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRequest : TeaModel {
        /// <summary>
        /// The instance ID of the image.
        /// 
        /// >  You can call the [DescribeImageInstances](~~DescribeImageInstances~~) operation to query the IDs of instances.
        /// </summary>
        [NameInMap("ImageInstanceId")]
        [Validation(Required=false)]
        public string ImageInstanceId { get; set; }

        /// <summary>
        /// The region ID of the image.
        /// 
        /// >  You can call the [DescribeImageInstances](~~DescribeImageInstances~~) operation to query the IDs of regions.
        /// </summary>
        [NameInMap("ImageRegionId")]
        [Validation(Required=false)]
        public string ImageRegionId { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// 
        /// >  You can call the [DescribeImageInstances](~~DescribeImageInstances~~) operation to query the IDs of image repositories.
        /// </summary>
        [NameInMap("ImageRepoId")]
        [Validation(Required=false)]
        public string ImageRepoId { get; set; }

        /// <summary>
        /// The tag that is added to the image.
        /// 
        /// >  You can call the [DescribeImageInstances](~~DescribeImageInstances~~) operation to query tags.
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

    }

}
