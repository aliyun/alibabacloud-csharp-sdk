// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class AddRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The background color in RGB format. Default value: 0 (black). The calculation formula is R + G × 256 + B × 65536. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// <para>The list of background images.</para>
        /// </summary>
        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<AddRecordTemplateRequestBackgrounds> Backgrounds { get; set; }
        public class AddRecordTemplateRequestBackgrounds : TeaModel {
            /// <summary>
            /// <para>Specifies whether to display the background image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (None): Not displayed.</description></item>
            /// <item><description><b>1</b> (Always): Always displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <para>The height of the background image pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS URL of the background image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width of the background image pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate of the background image, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate of the background image, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>The Z-order of the background image. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// <para>The list of clocks.</para>
        /// </summary>
        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<AddRecordTemplateRequestClockWidgets> ClockWidgets { get; set; }
        public class AddRecordTemplateRequestClockWidgets : TeaModel {
            /// <summary>
            /// <para>The text color of the clock in RGB format.</para>
            /// <para>The calculation formula is <c>R + G × 256 + B × 65536</c>. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            /// <summary>
            /// <para>The font size of the clock. Valid values: <b>(0, 72]</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <para>The font type of the clock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (default): NOTO_SERIF_CJKSC_REGULAR.</description></item>
            /// <item><description><b>1</b>: ALIBABA_PUHUITI_REGULAR.</description></item>
            /// <item><description><b>2</b>: ALIBABA_PUHUITI_BOLD.</description></item>
            /// <item><description><b>3</b>: ALIBABA_PUHUITI_Heavy.</description></item>
            /// <item><description><b>4</b>: ALIBABA_PUHUITI_LIGHT.</description></item>
            /// <item><description><b>5</b>: ALIBABA_PUHUITI_MEDIUM.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontType")]
            [Validation(Required=false)]
            public int? FontType { get; set; }

            /// <summary>
            /// <para>The X-coordinate of the clock, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate of the clock, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>The Z-order of the clock. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// <para>The delay time before stopping the recording. Unit: seconds. Default value: <b>180</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayStopTime")]
        [Validation(Required=false)]
        public int? DelayStopTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the timestamp of the TS file to the recorded M3U8 file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableM3u8DateTime")]
        [Validation(Required=false)]
        public bool? EnableM3u8DateTime { get; set; }

        /// <summary>
        /// <para>The splitting duration of the recording file. The value must be greater than or equal to 1800. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("FileSplitInterval")]
        [Validation(Required=false)]
        public int? FileSplitInterval { get; set; }

        /// <summary>
        /// <para>The list of recording file formats.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp4</para>
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <para>The HTTP callback URL for recording events.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or MnsQueue. You cannot specify both or neither.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("HttpCallbackUrl")]
        [Validation(Required=false)]
        public string HttpCallbackUrl { get; set; }

        /// <summary>
        /// <para>The list of layout IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        /// <summary>
        /// <para>The encoding option. For more information, see the MediaEncode enum values below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        /// <summary>
        /// <para>The MSMQ for recording event callbacks.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or HttpCallbackUrl. You cannot specify both or neither.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>record-callback-queue</para>
        /// </summary>
        [NameInMap("MnsQueue")]
        [Validation(Required=false)]
        public string MnsQueue { get; set; }

        /// <summary>
        /// <para>The name of the recording configuration template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recording template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS bucket where the recording files are stored.</para>
        /// <remarks>
        /// <para>Only OSS buckets in the China (Shanghai) region are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc-record-oss</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The OSS endpoint of the region where the recording files are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The naming rule for recording files.</para>
        /// <remarks>
        /// <para>To ensure the uniqueness of recording file names, the naming rule is record/{AppId}/{ChannelId_TaskId}/{EscapedStartTime}_{EscapedEndTime}.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record/{AppId}/{ChannelId_TaskId}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("OssFilePrefix")]
        [Validation(Required=false)]
        public string OssFilePrefix { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing configuration of the task. You are charged based on your settings. For more information, see the TaskProfile enum values below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The resolution of the MediaEncode encoding option must be less than or equal to the resolution of TaskProfile.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The maximum number of layout panes must be less than or equal to the number of input channels of TaskProfile.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4IN_1080P</para>
        /// </summary>
        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        /// <summary>
        /// <para>The list of watermarks.</para>
        /// </summary>
        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<AddRecordTemplateRequestWatermarks> Watermarks { get; set; }
        public class AddRecordTemplateRequestWatermarks : TeaModel {
            /// <summary>
            /// <para>The transparency of the watermark. A value of 0.0 indicates fully transparent, and a value of 1.0 indicates fully opaque.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <para>Specifies whether to display the watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (None): Not displayed.</description></item>
            /// <item><description><b>1</b> (Always): Always displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <para>The height of the watermark pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>The HTTP or HTTPS URL of the watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width of the watermark pane, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate of the watermark, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate of the watermark, as a normalized percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>The Z-order of the watermark. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

    }

}
