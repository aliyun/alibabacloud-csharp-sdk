// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyTableAssociationsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. You can specify up to five filter conditions at a time.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTableAssociationsRequestFilter> Filter { get; set; }
        public class DescribeTransitRouterPolicyTableAssociationsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PolicyTableId</b>: the policy routing table ID.</description></item>
            /// <item><description><b>AttachmentId</b>: the network connectivity instance ID.</description></item>
            /// <item><description><b>AssociationId</b>: the policy routing table associate relationship instance ID.</description></item>
            /// </list>
            /// <para>By default, multiple filter conditions are connected by the <b>AND</b> logical operator. A result is returned only when all filter conditions are met.</para>
            /// <para>You can specify up to five filter conditions at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CenId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify the filter value based on the <b>Key</b> parameter. You can specify multiple filter values for a single <b>Key</b>. Multiple filter values are connected by the <b>OR</b> logical operator. A result is returned when any of the filter values is met.</para>
            /// <para>You can specify up to five filter values for a single filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query is available.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
