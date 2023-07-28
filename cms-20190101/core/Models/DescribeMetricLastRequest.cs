// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricLastRequest : TeaModel {
        /// <summary>
        /// The dimensions that specify the resources whose monitoring data you want to query.
        /// 
        /// Set the value to a collection of key-value pairs. A typical key-value pair is `instanceId:i-2ze2d6j5uhg20x47****`.
        /// 
        /// >  You can query a maximum of 50 instances in a single request.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The start of the time range to query monitoring data.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The namespace of the cloud service. Format: acs_service name.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The paging token.
        /// 
        /// *   If the number of results exceeds the maximum number of entries allowed on a single page, a paging token is returned.
        /// *   This token can be used as an input parameter to obtain the next page of results. If all results are obtained, no token is returned.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The expression that is used to calculate the query results in real time.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMetricLast**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The end of the time range to query monitoring data.
        /// 
        /// *   For second-level data, the start time is obtained by comparing the time that is specified by the startTime parameter and 20 minutes earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// *   For minute-level data, the start time is obtained by comparing the time that is specified by the startTime parameter and 2 hours earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// *   For hour-level data, the start time is obtained by comparing the time that is specified by the startTime parameter and two days earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
