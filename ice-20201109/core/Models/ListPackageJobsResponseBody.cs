// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListPackageJobsResponseBody : TeaModel {
        [NameInMap("PackageJobList")]
        [Validation(Required=false)]
        public ListPackageJobsResponseBodyPackageJobList PackageJobList { get; set; }
        public class ListPackageJobsResponseBodyPackageJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>019daf5780f74831b0e1a767c9f1c178</para>
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

            [NameInMap("PackageJobs")]
            [Validation(Required=false)]
            public List<ListPackageJobsResponseBodyPackageJobListPackageJobs> PackageJobs { get; set; }
            public class ListPackageJobsResponseBodyPackageJobListPackageJobs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-07T14:00:32Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-07T15:00:32Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<ListPackageJobsResponseBodyPackageJobListPackageJobsInputs> Inputs { get; set; }
                public class ListPackageJobsResponseBodyPackageJobListPackageJobsInputs : TeaModel {
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public ListPackageJobsResponseBodyPackageJobListPackageJobsInputsInput Input { get; set; }
                    public class ListPackageJobsResponseBodyPackageJobListPackageJobsInputsInput : TeaModel {
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
                /// <para>7b38a5d86f1e47838927b6e7ccb11cbe</para>
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
                /// <para>2022-07-07T15:00:32Z</para>
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
                public ListPackageJobsResponseBodyPackageJobListPackageJobsOutput Output { get; set; }
                public class ListPackageJobsResponseBodyPackageJobListPackageJobsOutput : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>5b40833e4c3e4d4e95a866abb9a42510</para>
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
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-07T14:00:32Z</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
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
