// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPackageJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the packaging job.</para>
        /// </summary>
        [NameInMap("PackageJob")]
        [Validation(Required=false)]
        public GetPackageJobResponseBodyPackageJob PackageJob { get; set; }
        public class GetPackageJobResponseBodyPackageJob : TeaModel {
            /// <summary>
            /// <para>The error code returned if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T11:34:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T11:44:05Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input of the job.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public List<GetPackageJobResponseBodyPackageJobInputs> Inputs { get; set; }
            public class GetPackageJobResponseBodyPackageJobInputs : TeaModel {
                /// <summary>
                /// <para>The information about the input stream file.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public GetPackageJobResponseBodyPackageJobInputsInput Input { get; set; }
                public class GetPackageJobResponseBodyPackageJobInputsInput : TeaModel {
                    /// <summary>
                    /// <para>The media object.</para>
                    /// <list type="bullet">
                    /// <item><description>If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported.</description></item>
                    /// <item><description>If Type is set to Media, the ID of a media asset is returned.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <para>The type of the media object. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                    /// <item><description>Media: a media asset.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource content bad.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T11:44:05Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output of the job.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public GetPackageJobResponseBodyPackageJobOutput Output { get; set; }
            public class GetPackageJobResponseBodyPackageJobOutput : TeaModel {
                /// <summary>
                /// <para>The media object.</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported.</description></item>
                /// <item><description>If Type is set to Media, the ID of a media asset is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.m3u8</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the media object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an OSS object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The URL of the output file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/output.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/output.m3u8</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>The ID of the MPS queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36f3fee40aa047c0b067d0fb85edc12b</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid values: 1 to 10. The greater the value, the higher the priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The state of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08T11:34:05Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The source of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>API</description></item>
            /// <item><description>WorkFlow</description></item>
            /// <item><description>Console</description></item>
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
            /// <para>{&quot;param&quot;: &quot;value&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
