// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516779348000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The type of operation logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PV_ZONE</b>: the logs that record the operations on built-in authoritative zones</description></item>
        /// <item><description><b>PV_RECORD</b>: the logs that record the operations on DNS records</description></item>
        /// <item><description><b>RESOLVER_RULE</b>: the logs that record the operations on forwarding rules</description></item>
        /// <item><description><b>CUSTOM_LINE</b>: the logs that record the operations on user-defined lines</description></item>
        /// <item><description><b>RESOLVER_ENDPOINT</b>: the logs that record the operations on outbound endpoints</description></item>
        /// <item><description><b>INBOUND_ENDPOINT</b>: the logs that record the operations on inbound endpoints</description></item>
        /// <item><description><b>CACHE_RESERVE_DOMAIN</b>: the logs that record the operations on cache retention domain names</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set EntityType to other values, all types of logs are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PV_ZONE</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The keyword of the operation or the operation content. Fuzzy search is supported. The value is not case-sensitive.</para>
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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
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
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516779348000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The zone ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set ZoneId to a zone ID, the logs that record the operations on the DNS records of the specified zone are queried.\</para>
        /// </description></item>
        /// <item><description><para>If you leave ZoneId empty, the logs that record the operations on all zones and the DNS records of these zones that belong to the current Alibaba Cloud account are queried.</para>
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
