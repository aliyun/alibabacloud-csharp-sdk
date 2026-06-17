// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>状态码。</para>
        /// <remarks>
        /// <para>200表示成功。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailedListResult")]
        [Validation(Required=false)]
        public PutResourceMetricRulesResponseBodyFailedListResult FailedListResult { get; set; }
        public class PutResourceMetricRulesResponseBodyFailedListResult : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesResponseBodyFailedListResultTarget> Target { get; set; }
            public class PutResourceMetricRulesResponseBodyFailedListResultTarget : TeaModel {
                [NameInMap("Result")]
                [Validation(Required=false)]
                public PutResourceMetricRulesResponseBodyFailedListResultTargetResult Result { get; set; }
                public class PutResourceMetricRulesResponseBodyFailedListResultTargetResult : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>错误信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>15D1440E-BF24-5A41-93E4-36864635179E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>操作是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>true：成功。</para>
        /// </description></item>
        /// <item><description><para>false：失败。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
