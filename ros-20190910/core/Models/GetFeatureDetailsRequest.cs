// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsRequest : TeaModel {
        /// <summary>
        /// The one or more features that you want to query. Valid values:
        /// 
        /// *   Terraform: the Terraform hosting feature.
        /// *   ResourceCleaner: the resource cleaner feature. You can use ALIYUN::ROS::ResourceCleaner to create a resource cleaner.
        /// *   TemplateScratch: the scenario feature.
        /// *   All: all features that are supported by ROS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

        /// <summary>
        /// The region ID of the stack. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
