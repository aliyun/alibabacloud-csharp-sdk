// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class TraceSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9574AFDC-ABF1-5068-AAE3-6958CEBD8740</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace information of the call chain.</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public List<TraceSiteResponseBodyTrace> Trace { get; set; }
        public class TraceSiteResponseBodyTrace : TeaModel {
            /// <summary>
            /// <para>Indicates whether the module is matched. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Matched")]
            [Validation(Required=false)]
            public bool? Matched { get; set; }

            /// <summary>
            /// <para>The feature module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecRules</para>
            /// </summary>
            [NameInMap("StepModuleName")]
            [Validation(Required=false)]
            public string StepModuleName { get; set; }

            /// <summary>
            /// <para>The matching results of rules in the feature module.</para>
            /// </summary>
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public List<TraceSiteResponseBodyTraceTrace> Trace { get; set; }
            public class TraceSiteResponseBodyTraceTrace : TeaModel {
                /// <summary>
                /// <para>The action to perform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The configuration type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>The mitigation capability (China).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn300</para>
                /// </summary>
                [NameInMap("DdosLevelDomestic")]
                [Validation(Required=false)]
                public string DdosLevelDomestic { get; set; }

                /// <summary>
                /// <para>The mitigation capability (global, excluding China).</para>
                /// 
                /// <b>Example:</b>
                /// <para>unlimit</para>
                /// </summary>
                [NameInMap("DdosLevelOversea")]
                [Validation(Required=false)]
                public string DdosLevelOversea { get; set; }

                /// <summary>
                /// <para>The environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Production</para>
                /// </summary>
                [NameInMap("EnvName")]
                [Validation(Required=false)]
                public string EnvName { get; set; }

                /// <summary>
                /// <para>The rule expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(ip.geoip.country eq \&quot;CN\&quot;)</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The mitigation capability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>week</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The load balancer domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ib.test.example.com</para>
                /// </summary>
                [NameInMap("LoadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// <para>The name of the origin pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21212.origin-pool.example.com</para>
                /// </summary>
                [NameInMap("OriginPoolName")]
                [Validation(Required=false)]
                public string OriginPoolName { get; set; }

                /// <summary>
                /// <para>The routine ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.1097011697834102</para>
                /// </summary>
                [NameInMap("RoutineId")]
                [Validation(Required=false)]
                public string RoutineId { get; set; }

                /// <summary>
                /// <para>The security rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1297141</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public int? RuleId { get; set; }

                /// <summary>
                /// <para>The name of the matched rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cache_test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SiteVersion")]
                [Validation(Required=false)]
                public int? SiteVersion { get; set; }

                /// <summary>
                /// <para>The security-related rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>l4_ddos</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value specified in the IP access rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
