// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataStorageRequest : TeaModel {
        /// <summary>
        /// <para>The configuration version obtained from the query when modifying multi-account delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigurationVersion")]
        [Validation(Required=false)]
        public long? ConfigurationVersion { get; set; }

        /// <summary>
        /// <para>The region for log storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataStorageRegionId")]
        [Validation(Required=false)]
        public string DataStorageRegionId { get; set; }

        /// <summary>
        /// <para>The global delivery switch for log management. This parameter is not available for configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable: Enables all delivery.</description></item>
        /// <item><description>disable: Disables all delivery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("DeliveryStatus")]
        [Validation(Required=false)]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.
        /// Note: This parameter is required. If you do not specify this parameter, the API returns a 400 error: &quot;The specified Lang can not be empty.&quot; Specify zh or en.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The global switch for multi-account centralized delivery. If this parameter is omitted, the original storage update behavior is maintained. Do not mix this parameter with the storage region or the original delivery status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MultiAccountDeliveryEnabled")]
        [Validation(Required=false)]
        public bool? MultiAccountDeliveryEnabled { get; set; }

        /// <summary>
        /// <para>The region where the data management center for threat analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The current target project obtained from the query when modifying multi-account delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-1234567890123456-cn-shanghai</para>
        /// </summary>
        [NameInMap("TargetProject")]
        [Validation(Required=false)]
        public string TargetProject { get; set; }

    }

}
