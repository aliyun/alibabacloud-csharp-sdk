// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserWafRulesetsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies the execution phase of the WAF rule.</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: anti-scan rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: rate limit rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: advanced mode bot</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: security rule</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>Parameters for filtering and sorting the results.</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListUserWafRulesetsRequestQueryArgs QueryArgs { get; set; }
        public class ListUserWafRulesetsRequestQueryArgs : TeaModel {
            /// <summary>
            /// <para>Specifies whether to sort results in descending order.</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <para>A string for a fuzzy search of ruleset names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <para>The field by which to sort results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

        }

    }

}
