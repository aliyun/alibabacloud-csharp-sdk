// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersHistoryResponseBody : TeaModel {
        /// <summary>
        /// The number of the page to return.    
        /// - Start value: 1   
        /// - Default value: 1
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the parameter modification took effect.
        /// </summary>
        [NameInMap("Respond")]
        [Validation(Required=false)]
        public List<DescribeParametersHistoryResponseBodyRespond> Respond { get; set; }
        public class DescribeParametersHistoryResponseBodyRespond : TeaModel {
            /// <summary>
            /// The end time for the query of parameter modification history.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of rows to return on each page.   
            /// - Maximum value: 100   
            /// - Default value: 10
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParametersHistoryResponseBodyRespondParameters> Parameters { get; set; }
            public class DescribeParametersHistoryResponseBodyRespondParameters : TeaModel {
                /// <summary>
                /// The request ID.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// ```
                /// http(s)://[Endpoint]/?Action=DescribeParametersHistory
                /// &InstanceId=ob317v4uif****
                /// &Dimension=TENANT
                /// &DimensionValue=ob2mr3oae0****
                /// &StartTime=2021-06-13 15:40:43
                /// &EndTime=2021-09-13 15:40:43
                /// &PageSize=10
                /// &PageNumber=1
                /// &Common request parameters
                /// ```
                /// </summary>
                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

                /// <summary>
                /// You can call this operation to query the modification history of cluster or tenant parameters.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// The start time of the time range for querying the parameter modification history.
                /// </summary>
                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

                /// <summary>
                /// -
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// The list of parameter modification records.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
