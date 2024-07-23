// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSnapshotJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public GetSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class GetSnapshotJobResponseBodySnapshotJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ResourceNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-12T16:30:54Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public GetSnapshotJobResponseBodySnapshotJobInput Input { get; set; }
            public class GetSnapshotJobResponseBodySnapshotJobInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://test-bucket/object.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetSnapshotJobResponseBodySnapshotJobInputOssFile OssFile { get; set; }
                public class GetSnapshotJobResponseBodySnapshotJobInputOssFile : TeaModel {
                    /// <summary>
                    /// <para>OSS Bucket</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-bucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>OSS Location</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>OSS Object</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>object.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The specified resource for &quot;Pipeline&quot; could not be found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-12T16:30:54Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetSnapshotJobResponseBodySnapshotJobOutput Output { get; set; }
            public class GetSnapshotJobResponseBodySnapshotJobOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/output-%7BCount%7D.jpg">http://test-bucket.oss-cn-shanghai.aliyuncs.com/output-{Count}.jpg</a></para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetSnapshotJobResponseBodySnapshotJobOutputOssFile OssFile { get; set; }
                public class GetSnapshotJobResponseBodySnapshotJobOutputOssFile : TeaModel {
                    /// <summary>
                    /// <para>OSS Bucket</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-bucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>OSS Location</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>OSS Object</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>output-{Count}.jpg</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Type&quot;:&quot;Normal&quot;,&quot;FrameType&quot;:&quot;normal&quot;,&quot;Time&quot;:0,&quot;Count&quot;:10}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Sprite</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;test parameter&quot;: &quot;test value&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
