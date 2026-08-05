// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveRecordVodConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application name. You can view the <c>AppName</c> on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
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
        /// <para>Notice: This parameter is ignored if the <c>RecordFormat</c> parameter is specified.
        /// Specifies whether to enable automatic composition. Valid values:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Enables automatic composition. If you set this value to ON, you must also specify the <c>ComposeVodTranscodeGroupId</c> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("AutoCompose")]
        [Validation(Required=false)]
        public string AutoCompose { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is ignored if the <c>RecordFormat</c> parameter is specified.
        /// The ID of the ApsaraVideo for VOD transcoding template group used to transcode the video after automatic composition.</para>
        /// </remarks>
        /// <remarks>
        /// <para>You can get the ID by calling the <a href="https://help.aliyun.com/document_detail/454928.html">Query Transcoding Configuration List</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ComposeVodTranscodeGroupId")]
        [Validation(Required=false)]
        public string ComposeVodTranscodeGroupId { get; set; }

        /// <summary>
        /// <para>The duration of each cyclical recording file, in seconds. Default value: <b>3600</b>. Valid values: <b>300</b> to <b>21600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("CycleDuration")]
        [Validation(Required=false)]
        public int? CycleDuration { get; set; }

        /// <summary>
        /// <para>The maximum duration of a stream interruption, in seconds. If a stream interruption exceeds this duration, the system generates a new file. Valid values: 15 to 21600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

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
        /// <para>The on-demand recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Disables on-demand recording.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enables on-demand recording triggered by an HTTP callback.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Triggers recording by parsing push streaming parameters.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: Manual recording. Call the <a href="https://help.aliyun.com/document_detail/2847882.html">RealTimeRecordCommand</a> operation to start or stop recording.</para>
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
        /// <para>A list of parameters for each recording format.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<UpdateLiveRecordVodConfigRequestRecordFormat> RecordFormat { get; set; }
        public class UpdateLiveRecordVodConfigRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic composition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ON</c>: Enables automatic composition.</para>
            /// </description></item>
            /// <item><description><para><c>OFF</c>: Disables automatic composition.</para>
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
            /// <para>The recording storage format.</para>
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
            /// <item><description><para><c>transcode</c>: Processes the video by using a transcoding template group.</para>
            /// </description></item>
            /// <item><description><para><c>workflow</c>: Processes the video by using a workflow.</para>
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
            /// <h2>The ID must match the video processing method specified in ProcessMethod. For example, if ProcessMethod is set to transcode, you must use a transcoding template group ID.</h2>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>e2d796d3bb5fd8049d32bff62f94****</para>
            /// </summary>
            [NameInMap("ProcessTemplateId")]
            [Validation(Required=false)]
            public string ProcessTemplateId { get; set; }

            /// <summary>
            /// <para>The duration of each segment, in seconds.</para>
            /// <remarks>
            /// <para>Notice: This parameter applies only to the <c>m3u8</c> format.
            /// The default value is 30. Valid values: 5 to 30.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>A tag for video classification.</para>
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
            /// <item><description><para><c>origin</c> (default): Processes the source video.</para>
            /// </description></item>
            /// <item><description><para><c>compose</c>: Processes the composed video.</para>
            /// </description></item>
            /// </list>
            /// <para>To process both the source and composed videos, separate the values with a comma. For example, <c>origin,compose</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin</para>
            /// </summary>
            [NameInMap("VideoProcess")]
            [Validation(Required=false)]
            public string VideoProcess { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stream name. You can view the <c>StreamName</c> on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>A list of transcoding templates.</para>
        /// </summary>
        [NameInMap("TranscodeTemplates")]
        [Validation(Required=false)]
        public List<string> TranscodeTemplates { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is ignored if the <c>RecordFormat</c> parameter is specified. The ID of the ApsaraVideo for VOD transcoding template group.</para>
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
