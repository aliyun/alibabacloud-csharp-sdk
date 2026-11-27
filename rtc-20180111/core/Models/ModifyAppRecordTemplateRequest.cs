// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. Create and query through the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Recording template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public ModifyAppRecordTemplateRequestRecordTemplate RecordTemplate { get; set; }
        public class ModifyAppRecordTemplateRequestRecordTemplate : TeaModel {
            /// <summary>
            /// <para>Delayed stop recording time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("DelayStopTime")]
            [Validation(Required=false)]
            public int? DelayStopTime { get; set; }

            /// <summary>
            /// <para>The naming convention for recording files.</para>
            /// <remarks>
            /// <para>To ensure unique recording file names, use the following naming convention: <c>record/{AppId}/{ChannelId}/{TaskId}/{EscapedStartTime}/{EscapedEndTime}</c>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppId}/{ChannelId}<em>{TaskId}/{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("FilePrefix")]
            [Validation(Required=false)]
            public string FilePrefix { get; set; }

            /// <summary>
            /// <para>Recording file split duration (greater than or equal to 1800). Unit: seconds.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public int? FileSplitInterval { get; set; }

            /// <summary>
            /// <para>Recording file format. Currently, only .m3u8, .mp4, and .flv are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            /// <summary>
            /// <para>Layout ID list, up to 16.</para>
            /// <para>Note: The layouts in the list must not have the same number of data sources.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>Encoding options.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>Template name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模版</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2xh6****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

    }

}
