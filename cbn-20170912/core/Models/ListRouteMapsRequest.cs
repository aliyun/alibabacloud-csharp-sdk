// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListRouteMapsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a value for this parameter on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
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
        /// <item><description><b>true</b>: sends a check request without performing the query. The system checks whether required parameters are specified, the request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        public List<ListRouteMapsRequestFilter> Filter { get; set; }
        public class ListRouteMapsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Direction</b>: the direction of the route map.</description></item>
            /// <item><description><b>Name</b>: the name of the route map.</description></item>
            /// <item><description><b>Priority</b>: the priority of the route map.</description></item>
            /// </list>
            /// <para>By default, multiple filter conditions are connected by an AND logical operator. A route map must meet all filter conditions to be considered a match.</para>
            /// <para>You can specify up to 5 filter conditions at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Priority</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify the filter value based on the <b>Key</b>. You can specify multiple filter values for a single <b>Key</b>. Multiple filter values are connected by an OR logical operator. A route map that meets any of the filter values is considered a match for the filter condition.</para>
            /// <para>You can specify up to 5 filter values for a single filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.
        /// If you do not specify the MaxResults parameter, pagination is not used. After you call the operation, the value of MaxResults indicates the total number of entries. If you specify the MaxResults parameter, pagination is used. After you call the operation, the value of MaxResults indicates the number of entries on the current page. We recommend that you set MaxResults to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no next query is available, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next query is available, set the value to the <b>NextToken</b> value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-0a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the route maps to query. If you do not specify this parameter, all route maps are queried.</para>
        /// </summary>
        [NameInMap("RouteMapIds")]
        [Validation(Required=false)]
        public List<string> RouteMapIds { get; set; }

    }

}
