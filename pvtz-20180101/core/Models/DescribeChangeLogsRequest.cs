// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsRequest : TeaModel {
        /// <summary>
        /// <para>The end time. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2516779348000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The type of log to obtain. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PV_ZONE</b>: operation logs of built-in authoritative zones.</para>
        /// </description></item>
        /// <item><description><para><b>PV_RECORD</b>: operation logs of DNS records.</para>
        /// </description></item>
        /// <item><description><para><b>RESOLVER_RULE</b>: operation logs of forwarding rules.</para>
        /// </description></item>
        /// <item><description><para><b>CUSTOM_LINE</b>: operation logs of custom lines.</para>
        /// </description></item>
        /// <item><description><para><b>RESOLVER_ENDPOINT</b>: operation logs of outbound endpoints.</para>
        /// </description></item>
        /// <item><description><para><b>INBOUND_ENDPOINT</b>: operation logs of inbound endpoints.</para>
        /// </description></item>
        /// <item><description><para><b>CACHE_RESERVE_DOMAIN</b>: operation logs of domains for which cache is retained.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify another value, this parameter is ignored and logs of all types are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PV_ZONE</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The keyword, such as a behavior or content. Fuzzy search is supported. The keyword is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516779348000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The IP address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify this parameter, the operation returns the change logs of DNS records for the specified zone.<br></para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the operation returns the change logs of all zones and DNS records that belong to the current account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>df2d03865266bd9842306db586d3****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
