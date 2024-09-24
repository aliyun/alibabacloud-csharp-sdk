// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDynamicImageJobResponseBody : TeaModel {
        [NameInMap("DynamicImageJob")]
        [Validation(Required=false)]
        public GetDynamicImageJobResponseBodyDynamicImageJob DynamicImageJob { get; set; }
        public class GetDynamicImageJobResponseBodyDynamicImageJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ResourceNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

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
            public GetDynamicImageJobResponseBodyDynamicImageJobInput Input { get; set; }
            public class GetDynamicImageJobResponseBodyDynamicImageJobInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://test-bucket/sample-input.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetDynamicImageJobResponseBodyDynamicImageJobInputOssFile OssFile { get; set; }
                public class GetDynamicImageJobResponseBodyDynamicImageJobInputOssFile : TeaModel {
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
                    /// <para>sample-input.mp4</para>
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
            /// <para>The specified resource for &quot;CustomTemplate&quot; could not be found.</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleJob</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetDynamicImageJobResponseBodyDynamicImageJobOutput Output { get; set; }
            public class GetDynamicImageJobResponseBodyDynamicImageJobOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>d80e4e4044975745c14b</b></b></para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetDynamicImageJobResponseBodyDynamicImageJobOutputOssFile OssFile { get; set; }
                public class GetDynamicImageJobResponseBodyDynamicImageJobOutputOssFile : TeaModel {
                    /// <summary>
                    /// <para>OSS Bucket</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sample-bucket</para>
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
                    /// <para>path/to/object</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Media</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/output.gif">http://test-bucket.oss-cn-shanghai.aliyuncs.com/output.gif</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

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
            /// <para>{&quot;Format&quot;:&quot;gif&quot;,&quot;Fps&quot;:5,&quot;Height&quot;:1080,&quot;Width&quot;:1920}</para>
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
            /// <para>{&quot;sampleParam&quot;: &quot;sampleValue&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>36-3C1E-4417-BDB2-1E034F</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
