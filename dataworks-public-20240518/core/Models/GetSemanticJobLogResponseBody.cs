// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSemanticJobLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log segments returned by the executor. The current POP contract does not expose sqlIndex or offset externally. Log segments are returned based on the default behavior of the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSemanticJobLogResponseBodyData> Data { get; set; }
        public class GetSemanticJobLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The raw log text returned in this response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>semantic job started</para>
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            /// <summary>
            /// <para>Indicates whether the current log segment has been read to the end. A value of true indicates that no more content follows this segment.</para>
            /// </summary>
            [NameInMap("LogEnd")]
            [Validation(Required=false)]
            public bool? LogEnd { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
