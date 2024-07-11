// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigNetworkRegionBlockRequest : TeaModel {
        /// <summary>
        /// The details of the configurations of blocked locations. This parameter is a JSON string. The value consists of the following fields:
        /// 
        /// *   **RegionBlockSwitch**: the status of the location blacklist feature. This field is required and must be of the string type. Valid values:
        /// 
        ///     *   **on**
        ///     *   **off**
        /// 
        /// *   **Countries**: the codes of the countries and areas from which you want to block requests. This field is optional and must be of the array type.
        /// 
        ///     **
        /// 
        ///     **Note** For more information about the codes of countries and areas, see [Location parameters](https://help.aliyun.com/document_detail/167926.html).
        /// 
        /// *   **Provinces**: the codes of the administrative regions in China from which you want to block requests. This field is optional and must be of the array type.
        /// 
        ///     **
        /// 
        ///     **Note** For more information about the codes of administrative regions in China, see [Location parameters](https://help.aliyun.com/document_detail/167926.html).
        /// 
        ///     For example, `[11,12]` specifies Beijing and Tianjin.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
