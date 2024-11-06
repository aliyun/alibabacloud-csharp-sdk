// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UpdateRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public int? BackgroundColor { get; set; }

        [NameInMap("Backgrounds")]
        [Validation(Required=false)]
        public List<UpdateRecordTemplateRequestBackgrounds> Backgrounds { get; set; }
        public class UpdateRecordTemplateRequestBackgrounds : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        [NameInMap("ClockWidgets")]
        [Validation(Required=false)]
        public List<UpdateRecordTemplateRequestClockWidgets> ClockWidgets { get; set; }
        public class UpdateRecordTemplateRequestClockWidgets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontColor")]
            [Validation(Required=false)]
            public int? FontColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FontSize")]
            [Validation(Required=false)]
            public int? FontSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FontType")]
            [Validation(Required=false)]
            public int? FontType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayStopTime")]
        [Validation(Required=false)]
        public int? DelayStopTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableM3u8DateTime")]
        [Validation(Required=false)]
        public bool? EnableM3u8DateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("FileSplitInterval")]
        [Validation(Required=false)]
        public int? FileSplitInterval { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp4</para>
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public List<string> Formats { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("HttpCallbackUrl")]
        [Validation(Required=false)]
        public string HttpCallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("LayoutIds")]
        [Validation(Required=false)]
        public List<long?> LayoutIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MediaEncode")]
        [Validation(Required=false)]
        public int? MediaEncode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>record-callback-queue</para>
        /// </summary>
        [NameInMap("MnsQueue")]
        [Validation(Required=false)]
        public string MnsQueue { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc-record-pre</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4IN_1080P</para>
        /// </summary>
        [NameInMap("TaskProfile")]
        [Validation(Required=false)]
        public string TaskProfile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76dasgb****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Watermarks")]
        [Validation(Required=false)]
        public List<UpdateRecordTemplateRequestWatermarks> Watermarks { get; set; }
        public class UpdateRecordTemplateRequestWatermarks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Alpha")]
            [Validation(Required=false)]
            public float? Alpha { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public int? Display { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/image.jpg">https://www.example.com/image.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2456</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7576</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

    }

}
