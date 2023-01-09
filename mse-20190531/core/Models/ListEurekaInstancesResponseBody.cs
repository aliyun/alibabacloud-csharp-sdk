// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListEurekaInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEurekaInstancesResponseBodyData> Data { get; set; }
        public class ListEurekaInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// The timeout period of the instance.\
            /// After the specified timeout period expires, the service is unavailable by default and is deleted.
            /// </summary>
            [NameInMap("DurationInSecs")]
            [Validation(Required=false)]
            public int? DurationInSecs { get; set; }

            /// <summary>
            /// The URL of the homepage.
            /// </summary>
            [NameInMap("HomePageUrl")]
            [Validation(Required=false)]
            public string HomePageUrl { get; set; }

            /// <summary>
            /// The hostname.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("IpAddr")]
            [Validation(Required=false)]
            public string IpAddr { get; set; }

            /// <summary>
            /// The time when the instance was last modified.
            /// </summary>
            [NameInMap("LastDirtyTimestamp")]
            [Validation(Required=false)]
            public long? LastDirtyTimestamp { get; set; }

            /// <summary>
            /// The time when the instance heartbeat was last checked.
            /// </summary>
            [NameInMap("LastUpdatedTimestamp")]
            [Validation(Required=false)]
            public long? LastUpdatedTimestamp { get; set; }

            /// <summary>
            /// The metadata.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// The service port number.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The maximum interval between two heartbeat checks after a heartbeat check times out.\
            /// Default value: 10.
            /// </summary>
            [NameInMap("RenewalIntervalInSecs")]
            [Validation(Required=false)]
            public int? RenewalIntervalInSecs { get; set; }

            /// <summary>
            /// The security port.
            /// </summary>
            [NameInMap("SecurePort")]
            [Validation(Required=false)]
            public int? SecurePort { get; set; }

            /// <summary>
            /// The number of service providers. The value is in the following format: Number of healthy instances/Total number of instances.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The virtual IP address (VIP).
            /// </summary>
            [NameInMap("VipAddress")]
            [Validation(Required=false)]
            public string VipAddress { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
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
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
