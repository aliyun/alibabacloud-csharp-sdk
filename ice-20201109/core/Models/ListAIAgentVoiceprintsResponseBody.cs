// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentVoiceprintsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Voiceprints")]
        [Validation(Required=false)]
        public List<ListAIAgentVoiceprintsResponseBodyVoiceprints> Voiceprints { get; set; }
        public class ListAIAgentVoiceprintsResponseBodyVoiceprints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-28T10:03:58.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-28T10:03:58.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vp_1699123456_8527</para>
            /// </summary>
            [NameInMap("VoiceprintId")]
            [Validation(Required=false)]
            public string VoiceprintId { get; set; }

        }

    }

}
