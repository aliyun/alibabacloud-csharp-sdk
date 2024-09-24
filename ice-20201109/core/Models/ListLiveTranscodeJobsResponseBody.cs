// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeJobsResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<ListLiveTranscodeJobsResponseBodyJobList> JobList { get; set; }
        public class ListLiveTranscodeJobsResponseBodyJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mytask</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputStream")]
            [Validation(Required=false)]
            public ListLiveTranscodeJobsResponseBodyJobListOutputStream OutputStream { get; set; }
            public class ListLiveTranscodeJobsResponseBodyJobListOutputStream : TeaModel {
                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public List<ListLiveTranscodeJobsResponseBodyJobListOutputStreamStreamInfos> StreamInfos { get; set; }
                public class ListLiveTranscodeJobsResponseBodyJobListOutputStreamStreamInfos : TeaModel {
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
            public ListLiveTranscodeJobsResponseBodyJobListStreamInput StreamInput { get; set; }
            public class ListLiveTranscodeJobsResponseBodyJobListStreamInput : TeaModel {
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
            /// <para><b><b>a046-263c-3560-978a-fb287666</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
