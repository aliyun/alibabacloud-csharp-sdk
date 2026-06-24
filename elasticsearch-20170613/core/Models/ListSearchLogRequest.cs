// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSearchLogRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp of the log, in milliseconds. The value must be within the last 7 days. If this parameter is not specified, all logs within the [current time - 7 days, endTime\] range are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1531910852074</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end timestamp of the log, in milliseconds. The value must be within the last 7 days. Specify this parameter. If this parameter is not specified, an empty result is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1531910852074</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The page number of the plug-in list. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The keyword to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host:<c>172.16.**.**</c> AND content:netty</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTANCELOG: primary log.</description></item>
        /// <item><description>SEARCHSLOW: searching slow log.</description></item>
        /// <item><description>INDEXINGSLOW: indexing slow log.</description></item>
        /// <item><description>JVMLOG: GC log.</description></item>
        /// <item><description>ES_SEARCH_ACCESS_LOG: Elasticsearch access log.</description></item>
        /// <item><description>AUDIT: audit log.</description></item>
        /// </list>
        /// <para>For limits on viewing logs, see <a href="https://help.aliyun.com/document_detail/72026.html">Query logs</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCELOG</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
