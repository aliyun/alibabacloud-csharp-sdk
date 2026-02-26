// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForDeleteDBNodesResponseBody : TeaModel {
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures Failures { get; set; }
        public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures : TeaModel {
            [NameInMap("Failures")]
            [Validation(Required=false)]
            public List<PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures> Failures { get; set; }
            public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>The precheck result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public bool? PreCheckResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B415BC6-FE84-5323-A255-42CF330DB99C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
