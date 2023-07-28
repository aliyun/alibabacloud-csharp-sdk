// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterOutputListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The configuration sets for exporting monitoring data.
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterOutputListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterOutputListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterOutputListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterOutputListResponseBodyDatapointsDatapoint : TeaModel {
                /// <summary>
                /// The JSON object that contains the details about the destination to which the monitoring data is exported.
                /// </summary>
                [NameInMap("ConfigJson")]
                [Validation(Required=false)]
                public DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson ConfigJson { get; set; }
                public class DescribeExporterOutputListResponseBodyDatapointsDatapointConfigJson : TeaModel {
                    /// <summary>
                    /// The AccessKey ID.
                    /// </summary>
                    [NameInMap("ak")]
                    [Validation(Required=false)]
                    public string Ak { get; set; }

                    /// <summary>
                    /// The Log Service endpoint to which the monitoring data is exported.
                    /// </summary>
                    [NameInMap("endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// The Logstore.
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// The Log Service project to which the monitoring data is exported.
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

                /// <summary>
                /// The time when the configuration set was created. The value is a UNIX timestamp.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The name of the configuration set.
                /// </summary>
                [NameInMap("DestName")]
                [Validation(Required=false)]
                public string DestName { get; set; }

                /// <summary>
                /// The service to which the monitoring data is exported.
                /// 
                /// > Only Log Service is supported. More services will be supported in the future.
                /// </summary>
                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
