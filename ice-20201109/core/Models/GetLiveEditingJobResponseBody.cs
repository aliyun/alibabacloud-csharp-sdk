// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingJobResponseBody : TeaModel {
        [NameInMap("LiveEditingJob")]
        [Validation(Required=false)]
        public GetLiveEditingJobResponseBodyLiveEditingJob LiveEditingJob { get; set; }
        public class GetLiveEditingJobResponseBodyLiveEditingJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; }]</para>
            /// </summary>
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public string Clips { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:52Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:40Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("LiveStreamConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig LiveStreamConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>domain.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>streamName</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>0cc6ba49eab379332c5b</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaProduceConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig MediaProduceConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Accurate</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4</a></para>
            /// </summary>
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The specific parameter LiveStreamConfig is not valid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:49Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OutputMediaConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig OutputMediaConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public long? Bitrate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.mp4</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://testice-testbucket.oss-cn-shanghai.aliyuncs.com/test.mp4">https://testice-testbucket.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
                /// </summary>
                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>outin-xxxxxx.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VOD_NO_TRANSCODE</para>
                /// </summary>
                [NameInMap("VodTemplateGroupId")]
                [Validation(Required=false)]
                public string VodTemplateGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>640</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;: &quot;value\&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
