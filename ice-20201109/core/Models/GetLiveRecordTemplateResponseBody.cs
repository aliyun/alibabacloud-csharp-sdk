// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The recording template.</para>
        /// </summary>
        [NameInMap("RecordTemplate")]
        [Validation(Required=false)]
        public GetLiveRecordTemplateResponseBodyRecordTemplate RecordTemplate { get; set; }
        public class GetLiveRecordTemplateResponseBodyRecordTemplate : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T03:26:36Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T03:26:36Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of recording formats.</para>
            /// </summary>
            [NameInMap("RecordFormatList")]
            [Validation(Required=false)]
            public List<GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList> RecordFormatList { get; set; }
            public class GetLiveRecordTemplateResponseBodyRecordTemplateRecordFormatList : TeaModel {
                /// <summary>
                /// <para>The duration of the recording cycle. Unit: seconds. If you do not specify this parameter, the default value 6 hours is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7200</para>
                /// </summary>
                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public int? CycleDuration { get; set; }

                /// <summary>
                /// <para>The output file format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m3u8</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The name of the recording file that is stored in Object Storage Service (OSS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>record/{JobId}/{Sequence}{EscapedStartTime}{EscapedEndTime}</para>
                /// </summary>
                [NameInMap("OssObjectPrefix")]
                [Validation(Required=false)]
                public string OssObjectPrefix { get; set; }

                /// <summary>
                /// <para>The duration of a single segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SliceDuration")]
                [Validation(Required=false)]
                public int? SliceDuration { get; set; }

                /// <summary>
                /// <para>The name of the TS segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>record/{JobId}/{UnixTimestamp}_{Sequence}</para>
                /// </summary>
                [NameInMap("SliceOssObjectPrefix")]
                [Validation(Required=false)]
                public string SliceOssObjectPrefix { get; set; }

            }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system</description></item>
            /// <item><description>custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C892855F-95DF-50D6-A28C-279ABDB76810</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
