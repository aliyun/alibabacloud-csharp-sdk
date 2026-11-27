// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateAppRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The recording template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public CreateAppRecordTemplateRequestRecordTemplate RecordTemplate { get; set; }
        public class CreateAppRecordTemplateRequestRecordTemplate : TeaModel {
            /// <summary>
            /// <para>The delay time before stopping the recording. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("DelayStopTime")]
            [Validation(Required=false)]
            public int? DelayStopTime { get; set; }

            /// <summary>
            /// <para>The naming rule for recorded files.</para>
            /// <remarks>
            /// <para>To ensure the uniqueness of recorded file names, the current naming rule for recorded files is record/{AppId}/{ChannelId}<em>{TaskId}/{EscapedStartTime}</em>{EscapedEndTime}.</para>
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
            /// <para>The splitting duration of the recorded file. The value must be greater than or equal to 1800. Unit: seconds.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("FileSplitInterval")]
            [Validation(Required=false)]
            public int? FileSplitInterval { get; set; }

            /// <summary>
            /// <para>The format of the recorded file. Only .m3u8, .mp4, and .flv are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<string> Formats { get; set; }

            /// <summary>
            /// <para>The list of layout IDs. A maximum of 16 layout IDs can be specified.</para>
            /// <para>Note: The layouts in the list must correspond to different numbers of data sources.</para>
            /// </summary>
            [NameInMap("LayoutIds")]
            [Validation(Required=false)]
            public List<string> LayoutIds { get; set; }

            /// <summary>
            /// <para>The encoding options.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MediaEncode")]
            [Validation(Required=false)]
            public int? MediaEncode { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
