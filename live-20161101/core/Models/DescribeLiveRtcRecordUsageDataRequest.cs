// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRtcRecordUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraVideo Real-time Communication application. You can view the ID in <a href="https://help.aliyun.com/document_detail/2355593.html">ApsaraVideo Real-time Communication application management</a>. Navigate to <b>ApsaraVideo Live &gt; Live+ &gt; Real-time Communication &gt; Application Management</b> to view your application IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intl7f92-a5a8*************7ce4eb44a6</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time for the query. The query granularity must be ≥ 5 minutes and ≤ 31 days. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for the query data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>3600 (default).</para>
        /// </description></item>
        /// <item><description><ol start="86400">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: single-stream recording mode.</para>
        /// </description></item>
        /// <item><description><para>1: stream mixing recording mode.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecordMode")]
        [Validation(Required=false)]
        public string RecordMode { get; set; }

        /// <summary>
        /// <para>The start time for the query. Format: yyyy-MM-ddTHH:mm:ssZ (UTC time).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
