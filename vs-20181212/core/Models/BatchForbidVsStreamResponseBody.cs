// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchForbidVsStreamResponseBody : TeaModel {
        [NameInMap("ForbidResult")]
        [Validation(Required=false)]
        public BatchForbidVsStreamResponseBodyForbidResult ForbidResult { get; set; }
        public class BatchForbidVsStreamResponseBodyForbidResult : TeaModel {
            [NameInMap("ForbidResultInfo")]
            [Validation(Required=false)]
            public List<BatchForbidVsStreamResponseBodyForbidResultForbidResultInfo> ForbidResultInfo { get; set; }
            public class BatchForbidVsStreamResponseBodyForbidResultForbidResultInfo : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public BatchForbidVsStreamResponseBodyForbidResultForbidResultInfoChannels Channels { get; set; }
                public class BatchForbidVsStreamResponseBodyForbidResultForbidResultInfoChannels : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public List<string> Channel { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>B058D71B-76EA-5DF6-ACAF-A617C1E7937F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
