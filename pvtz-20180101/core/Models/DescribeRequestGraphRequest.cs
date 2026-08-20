// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRequestGraphRequest : TeaModel {
        /// <summary>
        /// <para>The data ID. This parameter is used with BizType.</para>
        /// <list type="bullet">
        /// <item><description><para>If BizType is set to AUTH_ZONE, set this parameter to the zone ID.</para>
        /// </description></item>
        /// <item><description><para>If BizType is set to RESOLVER_RULE, set this parameter to the forwarding rule ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>b9c93a8954c4098731e863c04302f45a</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AUTH_ZONE: An authoritative zone.</para>
        /// </description></item>
        /// <item><description><para>RESOLVER_RULE: A forwarding rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH_ZONE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721723624000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721036404000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The user\&quot;s IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-f8zvrvr1payllgz38****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>To query the number of requests for a zone, specify either ZoneId or both BizType and BizId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>29c752a01cd281a20ddcfa****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
