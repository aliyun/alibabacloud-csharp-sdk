// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamMergeRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the output stream. For the configuration to take effect, this AppName must match the one in the ingest URL. Wildcards (<c>*</c>) are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the stream merge.</para>
        /// <para>The time must be in UTC and specified in the ISO 8601 standard format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <remarks>
        /// <para>The interval between <c>StartTime</c> and <c>EndTime</c> cannot exceed 7 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-29T01:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The AppName of the primary input stream. This value must match the AppName in the ingest URL for the primary stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1</para>
        /// </summary>
        [NameInMap("InAppName1")]
        [Validation(Required=false)]
        public string InAppName1 { get; set; }

        /// <summary>
        /// <para>The AppName of the backup input stream. This value must match the AppName in the ingest URL for the backup stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app2</para>
        /// </summary>
        [NameInMap("InAppName2")]
        [Validation(Required=false)]
        public string InAppName2 { get; set; }

        /// <summary>
        /// <para>The StreamName of the primary input stream. This value must match the StreamName in the ingest URL for the primary stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InStream1</para>
        /// </summary>
        [NameInMap("InStreamName1")]
        [Validation(Required=false)]
        public string InStreamName1 { get; set; }

        /// <summary>
        /// <para>The StreamName of the backup input stream. This value must match the StreamName in the ingest URL for the backup stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream2</para>
        /// </summary>
        [NameInMap("InStreamName2")]
        [Validation(Required=false)]
        public string InStreamName2 { get; set; }

        /// <summary>
        /// <para>The engine to use for stream merging.</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The new liveswitch engine.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: A legacy engine (such as rtmpr). This is the default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LiveMerger")]
        [Validation(Required=false)]
        public string LiveMerger { get; set; }

        /// <summary>
        /// <para>Parameters that define the failover conditions. A failover is triggered when one of the following conditions is met:</para>
        /// <ol>
        /// <item><description><para>An explicit stream disconnection occurs, such as an end-of-file (EOF) or network error.</para>
        /// </description></item>
        /// <item><description><para>The stutter rate exceeds 60% in the last 5 seconds.</para>
        /// </description></item>
        /// <item><description><para>A stream pulling timeout occurs if no frame data is received for 2 consecutive seconds.</para>
        /// </description></item>
        /// <item><description><para>The average frame rate over the period specified by <c>ali_max_no_frame_timeout</c> drops below <c>ali_low_frame_rate_threshold</c>. This condition applies even if there is no stream disconnection or stuttering. If you set <c>ali_max_no_frame_timeout</c>, the timeout for Condition 3 is also updated to this value.</para>
        /// </description></item>
        /// <item><description><para>If <c>block_all_jitter</c> is set to <c>1</c>, Conditions 2, 3, and 4 do not apply.</para>
        /// </description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description><c>ali_max_no_frame_timeout</c>: an integer from 2 to 10.<br><c>ali_low_frame_rate_threshold</c>: an integer from 1 to 200.<br><c>block_all_jitter</c>: <c>0</c> or <c>1</c>.<br><br></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ali_low_frame_rate_threshold=10&amp;ali_max_no_frame_timeout=5&amp;block_all_jitter=0</para>
        /// </summary>
        [NameInMap("MergeParameters")]
        [Validation(Required=false)]
        public string MergeParameters { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The live stream protocol for the input streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>rtmp</b> (Default)</para>
        /// </description></item>
        /// <item><description><para><b>rtc</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SelectAppName")]
        [Validation(Required=false)]
        public string SelectAppName { get; set; }

        [NameInMap("SelectStreamName")]
        [Validation(Required=false)]
        public string SelectStreamName { get; set; }

        /// <summary>
        /// <para>The start time of the stream merge.</para>
        /// <para>The time must be in UTC and specified in the ISO 8601 standard format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The StreamName of the output stream. For the configuration to take effect, this StreamName must match the one in the ingest URL. Wildcards (<c>*</c>) are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StreamName</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
