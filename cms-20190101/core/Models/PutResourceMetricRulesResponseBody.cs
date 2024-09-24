// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The alert rules that failed to be created for the resource.</para>
        /// </summary>
        [NameInMap("FailedListResult")]
        [Validation(Required=false)]
        public PutResourceMetricRulesResponseBodyFailedListResult FailedListResult { get; set; }
        public class PutResourceMetricRulesResponseBodyFailedListResult : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesResponseBodyFailedListResultTarget> Target { get; set; }
            public class PutResourceMetricRulesResponseBodyFailedListResultTarget : TeaModel {
                /// <summary>
                /// <para>The alert rule that failed to be created.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public PutResourceMetricRulesResponseBodyFailedListResultTargetResult Result { get; set; }
                public class PutResourceMetricRulesResponseBodyFailedListResultTargetResult : TeaModel {
                    /// <summary>
                    /// <para>The response code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The error message returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The request processing has failed due to some unknown error.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the request was successful. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a151cd6023eacee2f0978e03863cc1697c89508****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15D1440E-BF24-5A41-93E4-36864635179E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
