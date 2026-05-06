// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafBatchRuleShared : TeaModel {
        /// <summary>
        /// <para>The action that you want WAF to perform on requests that match the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The extended action configurations.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public WafBatchRuleSharedActions Actions { get; set; }
        public class WafBatchRuleSharedActions : TeaModel {
            /// <summary>
            /// <para>The custom response.</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public WafBatchRuleSharedActionsResponse Response { get; set; }
            public class WafBatchRuleSharedActionsResponse : TeaModel {
                /// <summary>
                /// <para>The custom response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>403</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The ID of the custom response page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies the cross-domain website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("CrossSiteId")]
        [Validation(Required=false)]
        public long? CrossSiteId { get; set; }

        /// <summary>
        /// <para>The expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src eq 1.1.1.1</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The matching rule.</para>
        /// </summary>
        [NameInMap("Match")]
        [Validation(Required=false)]
        public WafRuleMatch2 Match { get; set; }

        /// <summary>
        /// <para>Web SDK integration method: automatic integration (automatic) or manual integration (manual).</para>
        /// 
        /// <b>Example:</b>
        /// <para>automatic</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ruleset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Protection type: web or app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
