// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationGroupsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the instance groups of the application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApplicationGroupsResponseBodyData> Data { get; set; }
        public class DescribeApplicationGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// The version of the container, such as Ali-Tomcat, in which a High-speed Service Framework (HSF) application runs.
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// The ID of the group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The type of the group.
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// The address of the image. This parameter is required when the **PackageType** parameter is set to **Image**.
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// The version of the Java development kit (JDK) on which the deployment package of the application depends. This parameter is invalid when the **PackageType** parameter is set to **Image**.
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// The type of the application deployment package. Valid values:
            /// 
            /// *   When you use a Java package, set this value to **FatJar**, **War**, or **Image**.
            /// 
            /// *   When you use a PHP package, the following values are valid:
            /// 
            ///     *   **PhpZip**
            ///     *   **IMAGE_PHP\_5\_4**
            ///     *   **IMAGE_PHP\_5\_4\_ALPINE**
            ///     *   **IMAGE_PHP\_5\_5**
            ///     *   **IMAGE_PHP\_5\_5\_ALPINE**
            ///     *   **IMAGE_PHP\_5\_6**
            ///     *   **IMAGE_PHP\_5\_6\_ALPINE**
            ///     *   **IMAGE_PHP\_7\_0**
            ///     *   **IMAGE_PHP\_7\_0\_ALPINE**
            ///     *   **IMAGE_PHP\_7\_1**
            ///     *   **IMAGE_PHP\_7\_1\_ALPINE**
            ///     *   **IMAGE_PHP\_7\_2**
            ///     *   **IMAGE_PHP\_7\_2\_ALPINE**
            ///     *   **IMAGE_PHP\_7\_3**
            ///     *   **IMAGE_PHP\_7\_3\_ALPINE**
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// The address of the deployment package. This parameter is required when the **PackageType** parameter is set to **FatJar**, **War**, or **PhpZip**.
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// The version of the deployment package. This parameter is required when the **PackageType** parameter is set to **FatJar**, **War**, or **PhpZip**. The parameter value will be automatically generated when you use an image to deploy the application and specify the **ImageUrl** parameter.
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// The total number of instances.
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            /// <summary>
            /// The number of running instances.
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// The version of the Apache Tomcat container on which the deployment package of the application depends. This parameter is invalid when the **PackageType** parameter is set to **Image**.
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// The error code.
        /// 
        /// *   The **ErrorCode** parameter is not returned when the request succeeds.
        /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the information about instance groups of an application was obtained. Valid values:
        /// 
        /// *   **true**: indicates that the information was obtained.
        /// *   **false**: indicates that the information could not be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. It is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
