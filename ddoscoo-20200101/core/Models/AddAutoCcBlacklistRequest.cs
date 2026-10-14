// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AddAutoCcBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses to add to the blacklist. This is a JSON array. Each object in the array contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><b>src</b>: String. Required. The IP address to add.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can add up to 2,000 IP addresses per request.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;src&quot;:&quot;198.51.XX.XX&quot;},{&quot;src&quot;:&quot;198.52.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Blacklist")]
        [Validation(Required=false)]
        public string Blacklist { get; set; }

        /// <summary>
        /// <para>The expiration time for the blacklist entries, in seconds. Valid values: <b>300</b> to <b>604800</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro instance.</para>
        /// <remarks>
        /// <para>Call the <b>DescribeInstanceIds</b> operation to query the IDs of all Anti-DDoS Pro instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
