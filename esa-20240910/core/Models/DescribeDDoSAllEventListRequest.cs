// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSAllEventListRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query.</para>
        /// <para>The time must be in ISO 8601 format and in UTC. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>. The time range between <c>StartTime</c> and <c>EndTime</c> cannot exceed 31 days.</para>
        /// <para>If this parameter is not specified, it defaults to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of DDoS attack events to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>web-cc</b>: A web resource exhaustion attack.</para>
        /// </description></item>
        /// <item><description><para><b>cc</b>: A connection-based attack.</para>
        /// </description></item>
        /// <item><description><para><b>traffic</b>: A traffic-based attack.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the operation queries <c>web-cc</c> events by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web-cc</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The page number to return. Valid range: <b>1</b> to <b>100000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Valid values: <b>5</b>, <b>10</b>, and <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// <para>The time must be in ISO 8601 format and in UTC. Format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-12T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
