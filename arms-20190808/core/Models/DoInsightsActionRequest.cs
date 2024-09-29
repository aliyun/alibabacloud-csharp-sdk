// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DoInsightsActionRequest : TeaModel {
        /// <summary>
        /// <para>The query parameters. Different module types correspond to different query parameters.</para>
        /// <list type="bullet">
        /// <item><description>QueryTopo</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///     &quot;regionId&quot;: string,  # The region ID.
        ///     &quot;startTime&quot;: string, # The beginning of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///     &quot;endTime&quot;: string, # The end of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///     &quot;edgeFilter&quot;: { # The edge filter condition.
        ///         &quot;includeTypes&quot;: [EdgeType], # The edge types to be included.
        ///         &quot;excludeTypes&quot;: [EdgeType], # The edge types to be excluded.
        ///         &quot;fromNodeFilter&quot;: { # The source node filter condition.
        ///             &quot;includeEntityTypes&quot;: [EntityType] # The entity types to be included.
        ///             &quot;excludeEntityTypes&quot;: [EntityType] # The entity types to be excluded.
        ///         },
        ///         &quot;toNodeFilter&quot;: {  # The destination node filter condition.
        ///             &quot;includeEntityTypes&quot;: [EntityType] # The entity types to be included.
        ///             &quot;excludeEntityTypes&quot;: [EntityType] # The entity types to be excluded.
        ///         }
        ///     },
        ///     &quot;includeIsolatedNodes&quot;: bool, # Specifies whether to include isolated nodes.
        ///     &quot;isolatedNodeFilter&quot;: { # The isolated node filter condition.
        ///         &quot;includeEntityTypes&quot;: [EntityType] # The entity types to be included.
        ///         &quot;excludeEntityTypes&quot;: [EntityType] # The entity types to be excluded.
        ///      },
        ///     &quot;queryMetrics&quot;: boolean, # Specifies whether to query related red metrics during the metric query.
        ///     &quot;timeoutSecs&quot;: int, # The timeout duration for querying metrics.
        ///     &quot;redOption&quot;: { # A metric query option.
        ///         &quot;skipRt&quot;: boolean,  # Specifies whether to skip querying the response time.
        ///         &quot;skipCount&quot;: boolean, # Specifies whether to skip querying the number of requests.
        ///         &quot;skipError&quot;: boolean # Specifies whether to skip querying the number of errors.
        ///     }
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>QueryTopoRed</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>{
        ///     &quot;regionId&quot;: string,  # The region ID.
        ///     &quot;startTime&quot;: string, # The beginning of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///     &quot;endTime&quot;: string,   # The end of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///     &quot;edgeIds&quot;: [string]  # The IDs of the edges to query.
        ///     &quot;nodeIds&quot;: [string]  # The IDs of the nodes to query.
        ///     &quot;redOption&quot;: { # A metric query option.
        ///         &quot;skipRt&quot;: boolean,  # Specifies whether to skip querying the response time.
        ///         &quot;skipCount&quot;: boolean, # Specifies whether to skip querying the number of requests.
        ///         &quot;skipError&quot;: boolean # Specifies whether to skip querying the number of errors.
        ///     }
        /// }
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description><para>QueryTopo</para>
        /// <para>  {
        ///   &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;startTime&quot;: &quot;2024-07-23 19:16:00&quot;,<br>  &quot;endTime&quot;: &quot;2024-07-23 20:16:00&quot;, # Limit the topology query range to 2024-07-23 19:16:00 to 2024-07-23 20:16:00
        ///   &quot;edgeFilter&quot;: {
        ///       &quot;includeTypes&quot;: [
        ///           &quot;CALLS&quot; # The resulting topology only contains edges of call relationships.
        ///       ],
        ///       &quot;fromNodeFilter&quot;: {
        ///           &quot;includeEntityTypes&quot;: [ # The source node type of the call edge must be application type
        ///               &quot;APPLICATION&quot; 
        ///           ]
        ///       },
        ///       &quot;toNodeFilter&quot;: {
        ///           &quot;includeEntityTypes&quot;: [ # The target node of the call edge must be an application type or an external service type.
        ///               &quot;APPLICATION&quot;,
        ///               &quot;EXTERNAL_SERVICE&quot;
        ///           ]
        ///       }
        ///   },
        ///   &quot;includeIsolatedNodes&quot;: false, # The resulting topology does not contain isolated nodes
        ///   &quot;queryMetrics&quot;: true, # Synchronously query the RED indicator
        ///   &quot;timeoutSecs&quot;: 20, #It takes up to 20 seconds to query indicator data
        ///   &quot;redOption&quot;: { # The query indicators include time consumption, request volume, and query skip errors.
        ///       &quot;skipRt&quot;: false,
        ///       &quot;skipCount&quot;: false,
        ///       &quot;skipError&quot;: true
        ///   }
        ///   }</para>
        /// </description></item>
        /// <item><description><para>QueryTopoRed</para>
        /// <para>  {
        ///   &quot;regionId&quot;: &quot;cn-hangzhou&quot;,
        ///   &quot;startTime&quot;: &quot;2024-07-23 10:00:00&quot;,
        ///   &quot;endTime&quot;: &quot;2024-07-23 14:00:00&quot;,
        ///   &quot;edgeIds&quot;: [
        ///       &quot;097843bd50b06fbe2c6c1d8b761a7e8b&quot;
        ///   ],
        ///   &quot;nodeIds&quot;: [
        ///       &quot;23d973261c6923da1b5b7a571ec1aa8b&quot;
        ///   ],
        ///   &quot;redOption&quot;: { # The query indicators include time consumption, request volume, and query skip errors.
        ///       &quot;skipCount&quot;: false,
        ///       &quot;skipError&quot;: true,
        ///       &quot;skipRt&quot;: false
        ///   }
        ///   }</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The module type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QueryTopo: queries the topology.</description></item>
        /// <item><description>QueryTopoRed: queries the red topology metrics, such as the number of requests, response time, and number of errors.</description></item>
        /// </list>
        /// <para>Notice: The preceding features are still in canary release and are disabled by default. If you need to enable these features, submit a ticket in the Application Real-Time Monitoring Service (ARMS) console.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QueryTopo</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
