// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataStorageRequest : TeaModel {
        /// <summary>
        /// <para>The log storage region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataStorageRegionId")]
        [Validation(Required=false)]
        public string DataStorageRegionId { get; set; }

        /// <summary>
        /// <para>The global switch for log delivery in Log Management. This parameter is not yet available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enables global delivery.</para>
        /// </description></item>
        /// <item><description><para>disable: Disables global delivery.</para>
        /// </description></item>
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
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is located. This region must be the same as the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: The assets are in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of a member. An administrator can specify this parameter to switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
