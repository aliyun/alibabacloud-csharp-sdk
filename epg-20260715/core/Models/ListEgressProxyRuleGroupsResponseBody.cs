// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyRuleGroupsResponseBody : TeaModel {
        [NameInMap("EgressProxyRuleGroups")]
        [Validation(Required=false)]
        public List<ListEgressProxyRuleGroupsResponseBodyEgressProxyRuleGroups> EgressProxyRuleGroups { get; set; }
        public class ListEgressProxyRuleGroupsResponseBodyEgressProxyRuleGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-06T03:18:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eppool-2ze06f6a9a2067ae****</para>
            /// </summary>
            [NameInMap("EgressProxyIpPoolId")]
            [Validation(Required=false)]
            public string EgressProxyIpPoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eprg-uf60966a9633667c****</para>
            /// </summary>
            [NameInMap("EgressProxyRuleGroupId")]
            [Validation(Required=false)]
            public string EgressProxyRuleGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("EgressProxyRuleGroupName")]
            [Validation(Required=false)]
            public string EgressProxyRuleGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfmwj4y6s7***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEgressProxyRuleGroupsResponseBodyEgressProxyRuleGroupsTags> Tags { get; set; }
            public class ListEgressProxyRuleGroupsResponseBodyEgressProxyRuleGroupsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>epg</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A05AB5-5BED-56ED-8EE9-304FBC2F8537</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
