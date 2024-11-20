// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDynamicImageJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the snapshot job.</para>
        /// </summary>
        [NameInMap("DynamicImageJob")]
        [Validation(Required=false)]
        public GetDynamicImageJobResponseBodyDynamicImageJob DynamicImageJob { get; set; }
        public class GetDynamicImageJobResponseBodyDynamicImageJob : TeaModel {
            /// <summary>
            /// <para>Error codes</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:30:54Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input of the job.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public GetDynamicImageJobResponseBodyDynamicImageJobInput Input { get; set; }
            public class GetDynamicImageJobResponseBodyDynamicImageJobInput : TeaModel {
                /// <summary>
                /// <para>The input file. If Type is set to OSS, the URL of an OSS object is returned. If Type is set to Media, the ID of a media asset is returned. The URL of an OSS object can be in one of the following formats:</para>
                /// <ol>
                /// <item><description>OSS://bucket/object</description></item>
                /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</description></item>
                /// </ol>
                /// <para>In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://test-bucket/sample-input.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The three key elements of OSS.</para>
                /// </summary>
                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetDynamicImageJobResponseBodyDynamicImageJobInputOssFile OssFile { get; set; }
                public class GetDynamicImageJobResponseBodyDynamicImageJobInputOssFile : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-bucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS location.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The OSS object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sample-input.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The type of the input file. Valid values:</para>
                /// <ol>
                /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified resource for &quot;CustomTemplate&quot; could not be found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:30:54Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleJob</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output of the job.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetDynamicImageJobResponseBodyDynamicImageJobOutput Output { get; set; }
            public class GetDynamicImageJobResponseBodyDynamicImageJobOutput : TeaModel {
                /// <summary>
                /// <para>The input file. If Type is set to OSS, the URL of an OSS object is returned. If Type is set to Media, the ID of a media asset is returned. The URL of an OSS object can be in one of the following formats:</para>
                /// <ol>
                /// <item><description>OSS://bucket/object</description></item>
                /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>d80e4e4044975745c14b</b></b></para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The three key elements of OSS.</para>
                /// </summary>
                [NameInMap("OssFile")]
                [Validation(Required=false)]
                public GetDynamicImageJobResponseBodyDynamicImageJobOutputOssFile OssFile { get; set; }
                public class GetDynamicImageJobResponseBodyDynamicImageJobOutputOssFile : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sample-bucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS location.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The OSS object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>path/to/object</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The type of the input file. Valid values: OSS: an OSS object. Media: a media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Media</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The URL of the output animated image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/output.gif">http://test-bucket.oss-cn-shanghai.aliyuncs.com/output.gif</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>The ID of the MPS queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The state of the job.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Init: The job is submitted.</description></item>
            /// <item><description>Success: The job is successful.</description></item>
            /// <item><description>Fail: The job failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The animation template configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Format&quot;:&quot;gif&quot;,&quot;Fps&quot;:5,&quot;Height&quot;:1080,&quot;Width&quot;:1920}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>d80e4e4044975745c14b</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The request trigger source.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Console</description></item>
            /// <item><description>Workflow</description></item>
            /// <item><description>API</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sampleParam&quot;: &quot;sampleValue&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>36-3C1E-4417-BDB2-1E034F</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
