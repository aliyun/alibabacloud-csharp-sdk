// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DoInsightsActionRequest : TeaModel {
        /// <summary>
        /// The query parameters. Different module types correspond to different query parameters.
        /// 
        /// *   QueryTopo
        /// 
        /// <!---->
        /// 
        ///     {
        ///         "regionId": string,  # The region ID.
        ///         "startTime": string, # The beginning of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///         "endTime": string, # The end of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///         "edgeFilter": { # The edge filter condition.
        ///             "includeTypes": [EdgeType], # The edge types to be included.
        ///             "excludeTypes": [EdgeType], # The edge types to be excluded.
        ///             "fromNodeFilter": { # The source node filter condition.
        ///                 "includeEntityTypes": [EntityType] # The entity types to be included.
        ///                 "excludeEntityTypes": [EntityType] # The entity types to be excluded.
        ///             },
        ///             "toNodeFilter": {  # The destination node filter condition.
        ///                 "includeEntityTypes": [EntityType] # The entity types to be included.
        ///                 "excludeEntityTypes": [EntityType] # The entity types to be excluded.
        ///             }
        ///         },
        ///         "includeIsolatedNodes": bool, # Specifies whether to include isolated nodes.
        ///         "isolatedNodeFilter": { # The isolated node filter condition.
        ///             "includeEntityTypes": [EntityType] # The entity types to be included.
        ///             "excludeEntityTypes": [EntityType] # The entity types to be excluded.
        ///          },
        ///         "queryMetrics": boolean, # Specifies whether to query related red metrics during the metric query.
        ///         "timeoutSecs": int, # The timeout duration for querying metrics.
        ///     	"redOption": { # A metric query option.
        ///     		"skipRt": boolean,  # Specifies whether to skip querying the response time.
        ///     		"skipCount": boolean, # Specifies whether to skip querying the number of requests.
        ///     		"skipError": boolean # Specifies whether to skip querying the number of errors.
        ///     	}
        ///     }
        /// 
        /// *   QueryTopoRed
        /// 
        /// <!---->
        /// 
        ///     {
        ///         "regionId": string,  # The region ID.
        ///         "startTime": string, # The beginning of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///         "endTime": string,   # The end of the time range to query, in the yyyy-MM-dd HH:mm:ss format.
        ///         "edgeIds": [string]  # The IDs of the edges to query.
        ///         "nodeIds": [string]  # The IDs of the nodes to query.
        ///         "redOption": { # A metric query option.
        ///             "skipRt": boolean,  # Specifies whether to skip querying the response time.
        ///             "skipCount": boolean, # Specifies whether to skip querying the number of requests.
        ///             "skipError": boolean # Specifies whether to skip querying the number of errors.
        ///         }
        ///     }
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The module type. Valid values:
        /// 
        /// *   QueryTopo: queries the topology.
        /// *   QueryTopoRed: queries the red topology metrics, such as the number of requests, response time, and number of errors.
        /// 
        /// Notice: The preceding features are still in canary release and are disabled by default. If you need to enable these features, submit a ticket in the Application Real-Time Monitoring Service (ARMS) console.
        /// 
        /// *
        /// *
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
