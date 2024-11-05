// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchResumeVsStreamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResumeResult")]
        [Validation(Required=false)]
        public BatchResumeVsStreamResponseBodyResumeResult ResumeResult { get; set; }
        public class BatchResumeVsStreamResponseBodyResumeResult : TeaModel {
            [NameInMap("ResumeResultInfo")]
            [Validation(Required=false)]
            public List<BatchResumeVsStreamResponseBodyResumeResultResumeResultInfo> ResumeResultInfo { get; set; }
            public class BatchResumeVsStreamResponseBodyResumeResultResumeResultInfo : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels Channels { get; set; }
                public class BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public List<string> Channel { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

        }

    }

}
