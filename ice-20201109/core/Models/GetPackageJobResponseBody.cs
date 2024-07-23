// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPackageJobResponseBody : TeaModel {
        [NameInMap("PackageJob")]
        [Validation(Required=false)]
        public GetPackageJobResponseBodyPackageJob PackageJob { get; set; }
        public class GetPackageJobResponseBodyPackageJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08T11:34:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08T11:44:05Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public List<GetPackageJobResponseBodyPackageJobInputs> Inputs { get; set; }
            public class GetPackageJobResponseBodyPackageJobInputs : TeaModel {
                [NameInMap("Input")]
                [Validation(Required=false)]
                public GetPackageJobResponseBodyPackageJobInputsInput Input { get; set; }
                public class GetPackageJobResponseBodyPackageJobInputsInput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Resource content bad.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08T11:44:05Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetPackageJobResponseBodyPackageJobOutput Output { get; set; }
            public class GetPackageJobResponseBodyPackageJobOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.m3u8</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

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
            /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/output.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/output.m3u8</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36f3fee40aa047c0b067d0fb85edc12b</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08T11:34:05Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;param&quot;: &quot;value&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
