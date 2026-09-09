// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCustomBlockRecordRequest : TeaModel {
        /// <summary>
        /// <para>The IP address to block. Traffic from this IP address to the server is blocked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// <para>The direction of traffic to block between the custom IP address and the server.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound</description></item>
        /// <item><description><b>out</b>: outbound</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        /// <summary>
        /// <para>The expiration time of the policy. This value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1859094550000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The UUIDs of the asset instances. Separate multiple UUIDs with commas (,). You can call DescribeCloudCenterInstances to obtain the UUIDs of asset instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71c846d6-5c84-4714-acfc-58265bc3****,5013b5e8-1613-43a8-b4de-651db318****,df53f0ad-b3ba-4fe0-9ec7-f42a2ae2****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
