// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppRecordTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A7497D0-BEAE-58E7-B13A-751BD8EAE4C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeAppRecordTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeAppRecordTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-04T06:22:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The delay time before stopping the recording. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("DelayStopTime")]
            [Validation(Required=false)]
            public long? DelayStopTime { get; set; }

            /// <summary>
            /// <para>The naming rule for recording files.</para>
            /// <remarks>
            /// <para>To ensure the uniqueness of recording file names, the current naming rule is record/{AppId}/{ChannelId}<em>{TaskId}/{EscapedStartTime}</em>{EscapedEndTime}.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppId}/{ChannelId_TaskId}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("FilePrefix")]
            [Validation(Required=false)]
            public string FilePrefix { get; set; }

            /// <summary>
            /// <para>The splitting duration of the recording file. The value must be greater than or equal to 1800. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public long? FileSplitInterval { get; set; }

            /// <summary>
            /// <para>The formats of the recording file. Valid values: .m3u8, .mp4, and .flv.</para>
            /// <remarks>
            /// <para>Only lowercase letters are supported for file formats.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            /// <summary>
            /// <para>The list of layout IDs.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>The encoding options.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wv7N****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
