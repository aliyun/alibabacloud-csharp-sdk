// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterRuleSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The overall information about the cluster defense rules.</para>
        /// </summary>
        [NameInMap("ClusterRuleSummary")]
        [Validation(Required=false)]
        public GetClusterRuleSummaryResponseBodyClusterRuleSummary ClusterRuleSummary { get; set; }
        public class GetClusterRuleSummaryResponseBodyClusterRuleSummary : TeaModel {
            /// <summary>
            /// <para>The number of disabled cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CloseRuleCount")]
            [Validation(Required=false)]
            public int? CloseRuleCount { get; set; }

            /// <summary>
            /// <para>The number of alerts that are triggered by the cluster defense rules in the last seven days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InterceptionCount7Day")]
            [Validation(Required=false)]
            public long? InterceptionCount7Day { get; set; }

            /// <summary>
            /// <para>The status of the container firewall feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            /// <summary>
            /// <para>The interception mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InterceptionType")]
            [Validation(Required=false)]
            public int? InterceptionType { get; set; }

            /// <summary>
            /// <para>The number of enabled cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public int? OpenRuleCount { get; set; }

            /// <summary>
            /// <para>The total number of configured cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// <para>The number of recommended cluster defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuggestRuleCount")]
            [Validation(Required=false)]
            public int? SuggestRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>291B49F9-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
