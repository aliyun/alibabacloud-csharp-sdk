// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordVodConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application that the stream belongs to. You can find this value on the <a href="https://help.aliyun.com/document_detail/197397.html">stream management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is ignored if <c>RecordFormat</c> is specified.
        /// Specifies whether to automatically merge files from multiple recording cycles into a single file after a live stream ends.</para>
        /// </remarks>
        /// <para>A value of <b>ON</b> enables automatic merging. If enabled, you must also specify the <c>ComposeVodTranscodeGroupId</c> parameter. By default, automatic merging is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("AutoCompose")]
        [Validation(Required=false)]
        public string AutoCompose { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is ignored if <c>RecordFormat</c> is specified.
        /// The ID of the ApsaraVideo VOD transcoding template group for transcoding the merged video. This parameter is required if <c>AutoCompose</c> is set to <c>ON</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ComposeVodTranscodeGroupId")]
        [Validation(Required=false)]
        public string ComposeVodTranscodeGroupId { get; set; }

        /// <summary>
        /// <para>The cycle duration, in seconds. The default value is <b>3600</b>. The value must be between <b>300</b> and <b>21600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("CycleDuration")]
        [Validation(Required=false)]
        public int? CycleDuration { get; set; }

        /// <summary>
        /// <para>The stream interruption timeout, in seconds. If a stream interruption is shorter than this duration, recording continues in the same file. If the interruption is longer, a new file is created. Valid values: 15 to 21600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <remarks>
        /// <para>Ensure ApsaraVideo VOD is activated in the same region as the streaming domain.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The recording trigger mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (Default): Automatic recording.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: On-demand recording triggered by an HTTP callback.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: On-demand recording triggered by ingest parameters.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: Manual recording. Allows you to start and stop recording by calling the <c>RealTimeRecordCommand</c> operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnDemand")]
        [Validation(Required=false)]
        public int? OnDemand { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recorded content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>raw</c> (Default): Records the source stream.</para>
        /// </description></item>
        /// <item><description><para><c>transcode</c>: Records transcoded streams.</para>
        /// </description></item>
        /// </list>
        /// <para>To record both source and transcoded streams, provide a comma-separated list, for example, <c>raw,transcode</c>.</para>
        /// <remarks>
        /// <para>If this parameter is set to include <c>transcode</c>, you must specify at least one template in the <c>TranscodeTemplates</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>raw</para>
        /// </summary>
        [NameInMap("RecordContent")]
        [Validation(Required=false)]
        public string RecordContent { get; set; }

        /// <summary>
        /// <para>A list of format-specific recording configurations.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<AddLiveRecordVodConfigRequestRecordFormat> RecordFormat { get; set; }
        public class AddLiveRecordVodConfigRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically merge recording files for this format after the stream ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ON</c>: Enables automatic merging.</para>
            /// </description></item>
            /// <item><description><para><c>OFF</c>: Disables automatic merging.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("AutoCompose")]
            [Validation(Required=false)]
            public string AutoCompose { get; set; }

            /// <summary>
            /// <para>The recording format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>m3u8</c></para>
            /// </description></item>
            /// <item><description><para><c>flv</c></para>
            /// </description></item>
            /// <item><description><para><c>mp4</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The video processing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>transcode</c>: Uses a transcoding template group to process the video.</para>
            /// </description></item>
            /// <item><description><para><c>workflow</c>: Uses a workflow to process the video.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>transcode</para>
            /// </summary>
            [NameInMap("ProcessMethod")]
            [Validation(Required=false)]
            public string ProcessMethod { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group or workflow.</para>
            /// <remarks>
            /// <para>The specified ID must match the <c>ProcessMethod</c>. For example, provide a transcoding template group ID if <c>ProcessMethod</c> is <c>transcode</c>, or a workflow ID if <c>ProcessMethod</c> is <c>workflow</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>e2d796d3bb5fd8049d32bff62f94****</para>
            /// </summary>
            [NameInMap("ProcessTemplateId")]
            [Validation(Required=false)]
            public string ProcessTemplateId { get; set; }

            /// <summary>
            /// <para>The slice duration, in seconds.</para>
            /// <para>This parameter applies only to the <c>m3u8</c> format.</para>
            /// <para>The value must be between 5 and 30. The default is 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The tags for video categorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sports</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The video source to process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>origin</c> (Default): The per-cycle recording files.</para>
            /// </description></item>
            /// <item><description><para><c>compose</c>: The single video file composed from all cycles.</para>
            /// </description></item>
            /// </list>
            /// <para>To process both video sources, separate the values with a comma (,), for example, <c>origin,compose</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin</para>
            /// </summary>
            [NameInMap("VideoProcess")]
            [Validation(Required=false)]
            public string VideoProcess { get; set; }

        }

        /// <summary>
        /// <para>The region ID. The example value <c>cn-shanghai</c> indicates the China (Shanghai) region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the VOD application space. You can obtain this ID from the <b>VOD console</b> or by calling an <a href="https://help.aliyun.com/document_detail/454873.html">API operation to query application information</a>. This parameter applies only when the VOD application space feature is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <para>The storage location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****-tjptr2vatm.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// <para>The stream name. You can find this value on the <a href="https://help.aliyun.com/document_detail/197397.html">stream management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>A list of transcoding templates for recording transcoded streams.</para>
        /// </summary>
        [NameInMap("TranscodeTemplates")]
        [Validation(Required=false)]
        public List<string> TranscodeTemplates { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is ignored if <c>RecordFormat</c> is specified.
        /// The ID of the ApsaraVideo VOD transcoding template group for transcoding recorded videos.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e2d796d3bb5fd8049d32bff62f94****</para>
        /// </summary>
        [NameInMap("VodTranscodeGroupId")]
        [Validation(Required=false)]
        public string VodTranscodeGroupId { get; set; }

    }

}
