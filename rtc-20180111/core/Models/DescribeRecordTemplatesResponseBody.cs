// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRecordTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C292B80E-5175-4BA4-8CC292B80E-5175-4BA4-8C1E-2ABEC4D7C2FE1E-2ABEC4D7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The recording configuration templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeRecordTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeRecordTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The RGB value of the background color. Default value: <b>0</b> (black). The calculation formula is R + G × 256 + B × 65536. Valid values for R (red), G (green), and B (blue): <b>0</b> to <b>255</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackgroundColor")]
            [Validation(Required=false)]
            public int? BackgroundColor { get; set; }

            /// <summary>
            /// <para>The list of background image information.</para>
            /// </summary>
            [NameInMap("Backgrounds")]
            [Validation(Required=false)]
            public List<DescribeRecordTemplatesResponseBodyTemplatesBackgrounds> Backgrounds { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesBackgrounds : TeaModel {
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
                /// <para>The height of the background image pane. The value is a normalized percentage.</para>
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
                /// <para>The width of the background image pane. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The X-coordinate of the background image. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate of the background image. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The stacking order of the background image. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above the bottom layer, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The list of clock widgets.</para>
            /// </summary>
            [NameInMap("ClockWidgets")]
            [Validation(Required=false)]
            public List<DescribeRecordTemplatesResponseBodyTemplatesClockWidgets> ClockWidgets { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesClockWidgets : TeaModel {
                /// <summary>
                /// <para>The text color of the clock (RGB).</para>
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
                /// <item><description><b>0</b> (default): NOTO_SERIF_CJKSC_REGULAR</description></item>
                /// <item><description><b>1</b>: ALIBABA_PUHUITI_REGULAR</description></item>
                /// <item><description><b>2</b>: ALIBABA_PUHUITI_BOLD</description></item>
                /// <item><description><b>3</b>: ALIBABA_PUHUITI_Heavy</description></item>
                /// <item><description><b>4</b>: ALIBABA_PUHUITI_LIGHT</description></item>
                /// <item><description><b>5</b>: ALIBABA_PUHUITI_MEDIUM</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FontType")]
                [Validation(Required=false)]
                public int? FontType { get; set; }

                /// <summary>
                /// <para>The X-coordinate of the clock. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate of the clock. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The stacking order of the clock. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above the bottom layer, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The time is displayed in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-04T06:22:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The delay before stopping the recording. Unit: seconds.</para>
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
            /// <para>The file splitting duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public int? FileSplitInterval { get; set; }

            /// <summary>
            /// <para>The list of recording file formats. Valid formats include M3U8, FLV, and MP4.</para>
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            /// <summary>
            /// <para>The HTTP callback URL for recording events.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
            /// </summary>
            [NameInMap("HttpCallbackUrl")]
            [Validation(Required=false)]
            public string HttpCallbackUrl { get; set; }

            /// <summary>
            /// <para>The list of mixed-stream layout IDs used by the recording template.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<long?> LayoutIds { get; set; }

            /// <summary>
            /// <para>The encoding options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>The name of the Message Service (MNS) queue for recording event callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record-callback-queue</para>
            /// </summary>
            [NameInMap("MnsQueue")]
            [Validation(Required=false)]
            public string MnsQueue { get; set; }

            /// <summary>
            /// <para>The name of the recording configuration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the Object Storage Service (OSS) bucket where recording files are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtc-record-oss</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The naming rule for recording files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/pre/{AppId}/{ChannelId_TaskId}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssFilePrefix")]
            [Validation(Required=false)]
            public string OssFilePrefix { get; set; }

            /// <summary>
            /// <para>The task specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4IN_1080P</para>
            /// </summary>
            [NameInMap("TaskProfile")]
            [Validation(Required=false)]
            public string TaskProfile { get; set; }

            /// <summary>
            /// <para>The ID of the recording configuration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1ca698e2-57fa-4314-8e11-00d950d4****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The list of watermark information.</para>
            /// </summary>
            [NameInMap("Watermarks")]
            [Validation(Required=false)]
            public List<DescribeRecordTemplatesResponseBodyTemplatesWatermarks> Watermarks { get; set; }
            public class DescribeRecordTemplatesResponseBodyTemplatesWatermarks : TeaModel {
                /// <summary>
                /// <para>The transparency of the watermark. The value is a normalized percentage. A value of 0 indicates transparent, and a value of 1 indicates completely opaque.</para>
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
                /// <para>The height of the watermark pane. The value is a normalized percentage.</para>
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
                /// <para>The width of the watermark pane. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.2456</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The X-coordinate of the watermark. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y-coordinate of the watermark. The value is a normalized percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7576</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The stacking order of the watermark. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above the bottom layer, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
