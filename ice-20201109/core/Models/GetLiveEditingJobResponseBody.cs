// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the live editing job.</para>
        /// </summary>
        [NameInMap("LiveEditingJob")]
        [Validation(Required=false)]
        public GetLiveEditingJobResponseBodyLiveEditingJob LiveEditingJob { get; set; }
        public class GetLiveEditingJobResponseBodyLiveEditingJob : TeaModel {
            /// <summary>
            /// <para>The clips.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;StartTime\&quot;: \&quot; 2021-06-21T08:01:00Z\&quot;,  \&quot;EndTime\&quot;: \&quot; 2021-06-21T08:03:00Z\&quot; }]</para>
            /// </summary>
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public string Clips { get; set; }

            /// <summary>
            /// <para>The response code. Note: Pay attention to this parameter if the job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the live editing job was completed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:52Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the live editing job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:40Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the live editing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The live editing configurations.</para>
            /// </summary>
            [NameInMap("LiveStreamConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig LiveStreamConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The domain name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>streamName</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            /// <summary>
            /// <para>The media asset ID of the output file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>0cc6ba49eab379332c5b</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The production configurations.</para>
            /// </summary>
            [NameInMap("MediaProduceConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig MediaProduceConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig : TeaModel {
                /// <summary>
                /// <para>The editing mode. Default value: Accurate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Accurate</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The URL of the output file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4</a></para>
            /// </summary>
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }

            /// <summary>
            /// <para>The returned message. Note: Pay attention to this parameter if the job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specific parameter LiveStreamConfig is not valid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the live editing job was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:49Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The storage configurations of the output file.</para>
            /// </summary>
            [NameInMap("OutputMediaConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig OutputMediaConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig : TeaModel {
                /// <summary>
                /// <para>The bitrate of the output file. Unit: Kbit/s. You can leave this parameter empty. The default value is the maximum bitrate of the input materials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public long? Bitrate { get; set; }

                /// <summary>
                /// <para>If OutputMediaTarget is set to vod-media, this parameter indicates the file name of the output file. The value contains the file name extension but not the path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.mp4</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The height of the output file. You can leave this parameter empty. The default value is the maximum height of the input materials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The URL of the output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://testice-testbucket.oss-cn-shanghai.aliyuncs.com/test.mp4">https://testice-testbucket.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
                /// </summary>
                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                /// <summary>
                /// <para>If OutputMediaTarget is set to vod-media, this parameter indicates the storage location of the media asset in ApsaraVideo VOD. The storage location is the path of the file in ApsaraVideo VOD, excluding the prefix http://. Example: outin-xxxxxx.oss-cn-shanghai.aliyuncs.com.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outin-xxxxxx.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The ID of the VOD transcoding template group. If VOD transcoding is not required, set the value to VOD_NO_TRANSCODE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VOD_NO_TRANSCODE</para>
                /// </summary>
                [NameInMap("VodTemplateGroupId")]
                [Validation(Required=false)]
                public string VodTemplateGroupId { get; set; }

                /// <summary>
                /// <para>The width of the output file. You can leave this parameter empty. The default value is the maximum width of the input materials.</para>
                /// 
                /// <b>Example:</b>
                /// <para>640</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The ID of the live editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The state of the live editing job. Valid values: Init, Queuing, Processing, Success, and Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;: &quot;value\&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
