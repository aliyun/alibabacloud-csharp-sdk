// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of recording formats.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<CreateLiveRecordTemplateRequestRecordFormat> RecordFormat { get; set; }
        public class CreateLiveRecordTemplateRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>The cycle recording duration. Unit: seconds. If this parameter is not specified, the default value is 6 hours.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If a live stream is interrupted during a recording cycle but resumes within 3 minutes, the recording continues in the same recording file.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>A live stream must be interrupted for more than 3 minutes before the last recording file is generated. If you need to modify the default 3-minute interruption time, submit a ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The format.</para>
            /// <remarks>
            /// <para>If you select the m3u8 format, you must also set the request parameters SliceOssObjectPrefix and SliceDuration.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The name of the recording file stored in OSS.</para>
            /// <list type="bullet">
            /// <item><description><para>The file name must be less than 256 bytes and supports variable matching, including {JobId}, {Sequence}, {StartTime}, {EndTime}, {EscapedStartTime}, and {EscapedEndTime}.</para>
            /// </description></item>
            /// <item><description><para>The parameter value must contain {StartTime} or {EscapedStartTime} and {EndTime} or {EscapedEndTime}.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>The duration of a single slice. Unit: seconds.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when Format is set to m3u8.</para>
            /// </remarks>
            /// <para>If this parameter is not specified, the default value is 30 seconds. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The name of the TS slice.</para>
            /// <remarks>
            /// <para>This parameter is required only when Format is set to m3u8.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The default slice duration is 30 seconds. The name must be less than 256 bytes and supports variable matching, including {JobId}, {UnixTimestamp}, and {Sequence}.</description></item>
            /// <item><description>The parameter value must contain the {UnixTimestamp} and {Sequence} variables.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

        }

    }

}
