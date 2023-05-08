// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAlarmEventDetailResponseBody : TeaModel {
        /// <summary>
        /// The details about the alert event.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlarmEventDetailResponseBodyData Data { get; set; }
        public class DescribeAlarmEventDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("AlarmEventAliasName")]
            [Validation(Required=false)]
            public string AlarmEventAliasName { get; set; }

            /// <summary>
            /// The description of the alert event.
            /// </summary>
            [NameInMap("AlarmEventDesc")]
            [Validation(Required=false)]
            public string AlarmEventDesc { get; set; }

            /// <summary>
            /// The unique ID of the alert event.
            /// 
            /// >  To query the details about an alert event, you must specify the unique ID of the alert event. You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to query the unique IDs of alert events.
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// The name of the container application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// Indicates whether the online handling of the alert event is supported. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// Indicates whether you can cancel marking the alert event as a false positive. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// An array consisting of the cause of the alert event, which can be used to trace the alert event.
            /// </summary>
            [NameInMap("CauseDetails")]
            [Validation(Required=false)]
            public List<DescribeAlarmEventDetailResponseBodyDataCauseDetails> CauseDetails { get; set; }
            public class DescribeAlarmEventDetailResponseBodyDataCauseDetails : TeaModel {
                /// <summary>
                /// The key that is used to trace the alert event.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// An array consisting of the value that is used to trace the alert event.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue> Value { get; set; }
                public class DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue : TeaModel {
                    /// <summary>
                    /// The name of the field that displays tracing information.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the field that displays tracing information. Valid values:
                    /// 
                    /// *   **text**
                    /// *   **html**
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The value of the field that displays tracing information.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// Indicates whether the Safeguard Mode For Major Activities mode is enabled.
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// The ID of the container application.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The ID of the image to which the container belongs.
            /// </summary>
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            /// <summary>
            /// The name of the image to which the container belongs.
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// The data source of the alert event.
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// The timestamp when the alert event ends. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the associated instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the associated instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The ID of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            /// <summary>
            /// The name of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }

            /// <summary>
            /// The namespace of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            /// <summary>
            /// The ID of the Kubernetes cluster node.
            /// </summary>
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            /// <summary>
            /// The name of the Kubernetes cluster node.
            /// </summary>
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            /// <summary>
            /// The name of the Kubernetes pod.
            /// </summary>
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            /// <summary>
            /// The severity of the alert event. Valid values:
            /// 
            /// *   **serious**
            /// *   **suspicious**
            /// *   **remind**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The solution to the alert event.
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// The timestamp when the alert event starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The alert type of the alert event. Valid values:
            /// 
            /// *   Suspicious process
            /// *   Webshell
            /// *   Unusual logon
            /// *   Exception
            /// *   Sensitive file tampering
            /// *   Malicious process (cloud threat detection)
            /// *   Suspicious network connection
            /// *   Other
            /// *   Abnormal account
            /// *   Application intrusion event
            /// *   Cloud threat detection
            /// *   Precise defense
            /// *   Application whitelist
            /// *   Persistent webshell
            /// *   Web application threat detection
            /// *   Malicious script
            /// *   Threat intelligence
            /// *   Malicious network activity
            /// *   Cluster exception
            /// *   Webshell (on-premises threat detection)
            /// *   Vulnerability exploitation
            /// *   Malicious process (on-premises threat detection)
            /// *   Trusted exception
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The instance UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
