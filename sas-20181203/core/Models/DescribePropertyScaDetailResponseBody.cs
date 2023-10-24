// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyScaDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyScaDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The details about the asset fingerprints returned.
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyScaDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyScaDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// The type of the middleware, database, or web service. Valid values:
            /// 
            /// *   **system_service**: system service
            /// *   **software_library**: software library
            /// *   **docker_component**: container component
            /// *   **database**: database
            /// *   **web_container**: web container
            /// *   **jar**: JAR package
            /// *   **web_framework**: web framework
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The display name of the type of the middleware, database, or web service . Valid values:
            /// 
            /// *   System service
            /// *   Software library
            /// *   Container component
            /// *   Database
            /// *   Web container
            /// *   JAR package
            /// *   Web framework
            /// </summary>
            [NameInMap("BizTypeDispaly")]
            [Validation(Required=false)]
            public string BizTypeDispaly { get; set; }

            /// <summary>
            /// The command line of the process.
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// The path to the configuration file.
            /// </summary>
            [NameInMap("ConfigPath")]
            [Validation(Required=false)]
            public string ConfigPath { get; set; }

            /// <summary>
            /// The name of the container.
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The latest collection timestamp, which indicates the last timestamp when Security Center collected the information about the middleware, database, or web service. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The name of the image.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// The ID of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The public IP address of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The IP address that the process monitors.
            /// </summary>
            [NameInMap("ListenIp")]
            [Validation(Required=false)]
            public string ListenIp { get; set; }

            /// <summary>
            /// The protocol of the traffic on which the process listens. Valid values:
            /// 
            /// *   **UDP**
            /// *   **TCP**
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            /// <summary>
            /// The listening status of the process. Valid values:
            /// 
            /// *   **NONE**: not listening
            /// *   **LISTEN**: listening
            /// </summary>
            [NameInMap("ListenStatus")]
            [Validation(Required=false)]
            public string ListenStatus { get; set; }

            /// <summary>
            /// The name of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The path of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The PID.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The name of the Kubernetes pod.
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// The port of the middleware, database, or web service.
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
            /// The timestamp when the process starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// The name of the user who runs the process.
            /// </summary>
            [NameInMap("ProcessUser")]
            [Validation(Required=false)]
            public string ProcessUser { get; set; }

            /// <summary>
            /// The version verification information about the middleware, database, or web service.
            /// </summary>
            [NameInMap("Proof")]
            [Validation(Required=false)]
            public string Proof { get; set; }

            /// <summary>
            /// The version of the runtime environment.
            /// 
            /// >  The value of this parameter can be the Java Development Kit (JDK) version of the runtime environment for a Java process.
            /// </summary>
            [NameInMap("RuntimeEnvVersion")]
            [Validation(Required=false)]
            public string RuntimeEnvVersion { get; set; }

            /// <summary>
            /// The type of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The UUID of the server on which the middleware, database, or web service is run.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The version of the middleware, database, or web service.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The web directory.
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
