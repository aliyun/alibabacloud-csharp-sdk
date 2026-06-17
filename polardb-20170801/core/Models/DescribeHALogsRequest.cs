// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHALogsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>这是一个optional 字段，需要增加一个条件If specified,If specified, queries the high availability (HA) switchover records of <c>DBNodeId</c>. You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view the detailed information about all clusters under your account, including node IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-****************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-23T01:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The log type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HaSwitchLogList</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 5 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
