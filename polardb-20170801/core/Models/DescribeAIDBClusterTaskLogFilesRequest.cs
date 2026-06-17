// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTaskLogFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the model operator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-bp10gr***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The log type. Set the value to:</para>
        /// <list type="bullet">
        /// <item><description><b>sls</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
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
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>The default value is <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp10ze***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the results in reverse order. The default value is <em>false</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
