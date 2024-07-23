// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForDeleteDBNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the failed order.</para>
        /// </summary>
        [NameInMap("Failures")]
        [Validation(Required=false)]
        public PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures Failures { get; set; }
        public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailures : TeaModel {
            [NameInMap("Failures")]
            [Validation(Required=false)]
            public List<PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures> Failures { get; set; }
            public class PreCheckCreateOrderForDeleteDBNodesResponseBodyFailuresFailures : TeaModel {
                /// <summary>
                /// <para>The response code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>200</b>: success</description></item>
                /// <item><description><b>400</b>: client error</description></item>
                /// <item><description><b>401</b>: identity authentication failed</description></item>
                /// <item><description><b>404</b>: requested page not found</description></item>
                /// <item><description><b>500</b>: server error</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
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
