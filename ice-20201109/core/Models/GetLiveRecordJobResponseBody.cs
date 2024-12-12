// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the recording job.</para>
        /// </summary>
        [NameInMap("RecordJob")]
        [Validation(Required=false)]
        public GetLiveRecordJobResponseBodyRecordJob RecordJob { get; set; }
        public class GetLiveRecordJobResponseBodyRecordJob : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the recording job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab0e3e76-1e9d-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the recording job.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/imsnotify">https://example.com/imsnotify</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            /// <summary>
            /// <para>The storage address of the recording.</para>
            /// </summary>
            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobRecordOutput RecordOutput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobRecordOutput : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imsbucket1</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The endpoint of the storage service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The type of the storage address.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>vod</description></item>
                /// <item><description>oss</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The state of the recording job.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>paused: The job is paused.</description></item>
            /// <item><description>initial: The job is not started.</description></item>
            /// <item><description>started: The job is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>paused</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The URL of the live stream.</para>
            /// </summary>
            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobStreamInput StreamInput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobStreamInput : TeaModel {
                /// <summary>
                /// <para>The type of the live stream. The value can only be rtmp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://example.com/app/stream</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The ID of the recording template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the recording template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57A046C-CE33-5FBB-B57A-D2B89ACF6907</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
