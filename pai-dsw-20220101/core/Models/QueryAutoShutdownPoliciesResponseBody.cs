// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class QueryAutoShutdownPoliciesResponseBody : TeaModel {
        [NameInMap("AutoShutdownPolicies")]
        [Validation(Required=false)]
        public List<QueryAutoShutdownPoliciesResponseBodyAutoShutdownPolicies> AutoShutdownPolicies { get; set; }
        public class QueryAutoShutdownPoliciesResponseBodyAutoShutdownPolicies : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<QueryAutoShutdownPoliciesResponseBodyAutoShutdownPoliciesConditions> Conditions { get; set; }
            public class QueryAutoShutdownPoliciesResponseBodyAutoShutdownPoliciesConditions : TeaModel {
                [NameInMap("Context")]
                [Validation(Required=false)]
                public Dictionary<string, object> Context { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IdleDuration &gt; 1440 min AND CpuUtilization &lt;= 1%</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Workspace</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            [NameInMap("Context")]
            [Validation(Required=false)]
            [Obsolete]
            public Dictionary<string, object> Context { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>IdleDuration &gt; 1440 min AND CpuUtilization &lt;= 1%</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            [Obsolete]
            public string Expression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsw-05cefd0be2e5a278</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>Workspace</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            [Obsolete]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
