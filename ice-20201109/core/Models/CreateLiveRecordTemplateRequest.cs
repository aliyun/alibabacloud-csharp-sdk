// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template.</para>
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
            /// <para>The duration of the recording cycle. Unit: seconds. If you do not specify this parameter, the default value 6 hours is used.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If a live stream is interrupted during a recording cycle but is resumed within 3 minutes, the stream is recorded in the same recording before and after the interruption.</para>
            /// </description></item>
            /// <item><description><para>If a live stream is interrupted for more than 3 minutes, a new recording is generated. To change the default stream interruption time, submit a ticket.</para>
            /// </description></item>
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
            /// <para> If you set this parameter to m3u8, you must also specify the SliceOssObjectPrefix and SliceDuration parameters.</para>
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
            /// <para>The name of the recording file that is stored in Object Storage Service (OSS).</para>
            /// <list type="bullet">
            /// <item><description>The name must be less than 256 bytes in length and can contain the {JobId}, {Sequence}, {StartTime}, {EndTime}, {EscapedStartTime}, and {EscapedEndTime} variables.</description></item>
            /// <item><description>The name must contain the {StartTime} and {EndTime} variables or the {EscapedStartTime} and {EscapedEndTime} variables.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{JobId}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>The duration of a single segment. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set Format to m3u8.</para>
            /// </remarks>
            /// <para>If you do not specify this parameter, the default value 30 seconds is used. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The name of the TS segment.</para>
            /// <remarks>
            /// <para> This parameter is required only if you set Format to m3u8.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>By default, the duration of a segment is 30 seconds. The segment name must be less than 256 bytes in length and can contain the {JobId}, {UnixTimestamp}, and {Sequence} variables.</description></item>
            /// <item><description>The segment name must contain the {UnixTimestamp} and {Sequence} variables.</description></item>
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
