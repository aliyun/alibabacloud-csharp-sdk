// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveTranscodeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the transcoding job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetLiveTranscodeJobResponseBodyJob Job { get; set; }
        public class GetLiveTranscodeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the transcoding job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about the output stream.</para>
            /// </summary>
            [NameInMap("OutputStream")]
            [Validation(Required=false)]
            public GetLiveTranscodeJobResponseBodyJobOutputStream OutputStream { get; set; }
            public class GetLiveTranscodeJobResponseBodyJobOutputStream : TeaModel {
                /// <summary>
                /// <para>The information about the output stream.</para>
                /// </summary>
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public List<GetLiveTranscodeJobResponseBodyJobOutputStreamStreamInfos> StreamInfos { get; set; }
                public class GetLiveTranscodeJobResponseBodyJobOutputStreamStreamInfos : TeaModel {
                    /// <summary>
                    /// <para>The URL of the output stream.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rtmp://mydomain/app/mytranscode1</para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <para>The type of the output stream protocol. Only the RTMP protocol is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rtmp</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The start mode of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartMode")]
            [Validation(Required=false)]
            public int? StartMode { get; set; }

            /// <summary>
            /// <para>The state of the job.</para>
            /// <list type="bullet">
            /// <item><description>0: The job is not started.</description></item>
            /// <item><description>1: The job is in progress.</description></item>
            /// <item><description>2: The job is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The information about the input stream.</para>
            /// </summary>
            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public GetLiveTranscodeJobResponseBodyJobStreamInput StreamInput { get; set; }
            public class GetLiveTranscodeJobResponseBodyJobStreamInput : TeaModel {
                /// <summary>
                /// <para>The URL of the input stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://mydomain/app/stream1</para>
                /// </summary>
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                /// <summary>
                /// <para>The type of the input stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b6491d5b3e514b7d895d14b5453ea119</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
