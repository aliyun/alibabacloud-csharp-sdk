// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordJobResponseBody : TeaModel {
        /// <summary>
        /// <para>录制任务</para>
        /// </summary>
        [NameInMap("RecordJob")]
        [Validation(Required=false)]
        public GetLiveRecordJobResponseBodyRecordJob RecordJob { get; set; }
        public class GetLiveRecordJobResponseBodyRecordJob : TeaModel {
            /// <summary>
            /// <para>代表创建时间的资源属性字段</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab0e3e76-1e9d-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>回调地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/imsnotify">https://example.com/imsnotify</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobRecordOutput RecordOutput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobRecordOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>imsbucket1</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>代表资源名称的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>paused</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public GetLiveRecordJobResponseBodyRecordJobStreamInput StreamInput { get; set; }
            public class GetLiveRecordJobResponseBodyRecordJobStreamInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp://example.com/app/stream</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>录制模板ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>录制模板ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B57A046C-CE33-5FBB-B57A-D2B89ACF6907</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
