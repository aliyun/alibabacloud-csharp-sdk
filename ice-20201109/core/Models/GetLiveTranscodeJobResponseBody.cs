// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveTranscodeJobResponseBody : TeaModel {
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetLiveTranscodeJobResponseBodyJob Job { get; set; }
        public class GetLiveTranscodeJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputStream")]
            [Validation(Required=false)]
            public GetLiveTranscodeJobResponseBodyJobOutputStream OutputStream { get; set; }
            public class GetLiveTranscodeJobResponseBodyJobOutputStream : TeaModel {
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public List<GetLiveTranscodeJobResponseBodyJobOutputStreamStreamInfos> StreamInfos { get; set; }
                public class GetLiveTranscodeJobResponseBodyJobOutputStreamStreamInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rtmp://mydomain/app/mytranscode1</para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rtmp</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartMode")]
            [Validation(Required=false)]
            public int? StartMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public GetLiveTranscodeJobResponseBodyJobStreamInput StreamInput { get; set; }
            public class GetLiveTranscodeJobResponseBodyJobStreamInput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp://mydomain/app/stream1</para>
                /// </summary>
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b6491d5b3e514b7d895d14b5453ea119</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
