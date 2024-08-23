// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DoInsightsActionResponseBody : TeaModel {
        /// <summary>
        /// Status code. 200 means success, other status codes are exceptions.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The response parameters vary with the value of module.
        /// 
        /// *   QueryTopo
        /// 
        ///         {
        ///          "nodes": [Node] # The collection of nodes. For more information, see the "Node" section of this topic.
        ///          "edges": [Edge] # The collection of edges. For more information, see the "Edge" section of this topic.
        ///         }
        /// 
        /// *   QueryTopoRed
        /// 
        ///         {
        ///           "nodeRed": {
        ///           	"nodeId": {
        ///           		"count": double, # The total number of requests in the specified time range.
        ///           		"error": double, # The total number of errors in the specified time range.
        ///           		"rt": double, # The average response time in the specified time range. Unit: milliseconds.
        ///           	}
        ///           },
        ///           "edgeRed": {
        ///           	"edgeId": {
        ///           	    "count": double, # The total number of requests in the specified time range.
        ///           		"error": double, # The total number of errors in the specified time range.
        ///           		"rt": double, # The average response time in the specified time range. Unit: milliseconds.
        ///           	}
        ///           }
        /// 
        /// }
        /// 
        /// ```
        /// ```
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// Information returned when the call fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Whether the query is successful:
        /// 
        /// - true
        /// - false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
