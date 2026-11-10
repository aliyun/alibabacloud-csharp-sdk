// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListRouteMapRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the parameter value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request, and no route map rules are queried. Check items include whether required parameters are specified, the request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the error code DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request, and route map rules are queried directly after the check succeeds.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// <para>You can specify up to 5 filter conditions at a time.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListRouteMapRulesRequestFilter> Filter { get; set; }
        public class ListRouteMapRulesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Name</b>: the name of the route map rule.</description></item>
            /// <item><description><b>Priority</b>: the priority of the route map rule.</description></item>
            /// </list>
            /// <para>By default, multiple filter conditions are evaluated by using the AND logical operator. A rule matches the filter conditions only if it meets all the filter conditions.</para>
            /// <para>You can specify up to 5 filter conditions at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify the filter value based on the Key. You can specify multiple filter values for a single Key. Multiple filter values are evaluated by using the OR logical operator. A rule matches the filter condition if it meets any of the filter values.</para>
            /// <para>You can specify up to 5 filter values for a single filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next page exists, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next page exists, set the value to the <b>NextToken</b> value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the route map to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-0a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// <para>The list of route map rule IDs to query. This parameter and filter conditions can be used together for matching, and the relationship is AND.</para>
        /// </summary>
        [NameInMap("RouteMapRuleIds")]
        [Validation(Required=false)]
        public List<string> RouteMapRuleIds { get; set; }

    }

}
