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
        /// *   **RegionBlockSwitch**: the status of the Location Blacklist policy. This field is required and must be of the string type. Valid values:
        /// 
        ///     *   **on**: enables the policy.
        ///     *   **off**: disables the policy.
        /// 
        /// *   **Countries**: the codes of the countries or areas from which you want to block requests. This field is optional and must be of the array type.
        /// 
        ///     **
        /// 
        ///     **Note**For more information, see the **Codes of countries and areas** section of the [Codes of administrative regions in China and codes of countries and areas](~~167926~~) topic.
        /// 
        ///     For example, `[1,2]` specifies China and Australia.
        /// 
        /// *   **Provinces**: the codes of the administrative regions in China from which you want to block requests. This field is optional and must be of the array type.
        /// 
        ///     **
        /// 
        ///     **Note**For more information, see the **Codes of administrative regions in China** section of the [Codes of administrative regions in China and codes of countries and areas](~~167926~~) topic.
        /// 
        ///     For example, `[11,12]` specifies Beijing and Tianjin.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
