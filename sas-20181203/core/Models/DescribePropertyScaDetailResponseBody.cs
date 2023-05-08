// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailResponseBody : TeaModel {
        /// <summary>
        /// 192.168
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyScaDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyScaDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The name of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The public IP address of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The version of the runtime environment.
            /// 
            /// >  The value of this parameter can be the Java Development Kit (JDK) version of the runtime environment for a Java process.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The listening status of the process. Valid values:
        /// 
        /// *   **NONE**: not listening
        /// *   **LISTEN**: listening
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyScaDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyScaDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// The path to the configuration file.
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The UUID of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("BizTypeDispaly")]
            [Validation(Required=false)]
            public string BizTypeDispaly { get; set; }

            /// <summary>
            /// The latest collection timestamp, which indicates the last timestamp when Security Center collected the information about the middleware, database, or web service. Unit: milliseconds.
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// The name of the user who runs the process.
            /// </summary>
            [NameInMap("ConfigPath")]
            [Validation(Required=false)]
            public string ConfigPath { get; set; }

            /// <summary>
            /// uuid-02ebabe7-1c19-ab****
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// 756
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The search condition, such as a server name or a server IP address.
            /// 
            /// >  Fuzzy match is supported.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the container.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// 1.0.2k
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// openssl
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// 68
            /// </summary>
            [NameInMap("ListenIp")]
            [Validation(Required=false)]
            public string ListenIp { get; set; }

            /// <summary>
            /// The PID.
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            /// <summary>
            /// The type of the subquery. Valid values:
            /// 
            /// *   **port**
            /// *   **pid**
            /// *   **version**
            /// *   **user**
            /// </summary>
            [NameInMap("ListenStatus")]
            [Validation(Required=false)]
            public string ListenStatus { get; set; }

            /// <summary>
            /// The version verification information about the middleware, database, or web service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The version of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The command line of the process.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The ID of the parent process.
            /// </summary>
            [NameInMap("Ppid")]
            [Validation(Required=false)]
            public string Ppid { get; set; }

            /// <summary>
            /// The user who runs the process.
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// The port that the process monitors.
            /// </summary>
            [NameInMap("ProcessUser")]
            [Validation(Required=false)]
            public string ProcessUser { get; set; }

            /// <summary>
            /// The type of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Proof")]
            [Validation(Required=false)]
            public string Proof { get; set; }

            /// <summary>
            /// open
            /// </summary>
            [NameInMap("RuntimeEnvVersion")]
            [Validation(Required=false)]
            public string RuntimeEnvVersion { get; set; }

            /// <summary>
            /// The name of the asset fingerprint that you want to query.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The protocol of the traffic on which the process listens. Valid values:
            /// 
            /// *   **UDP**
            /// *   **TCP**
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The type of the middleware, database, or web service that you want to query. Valid values:
            /// 
            /// *   **system_service**: system service
            /// *   **software_library**: software library
            /// *   **docker_component**: container component
            /// *   **database**: database
            /// *   **web_container**: web container
            /// *   **jar**: JAR package
            /// *   **web_framework**: web framework
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// zh
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

        }

        /// <summary>
        /// 1641024565
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
