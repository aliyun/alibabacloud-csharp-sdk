// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAlarmEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the alert event.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlarmEventDetailResponseBodyData Data { get; set; }
        public class DescribeAlarmEventDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("AlarmEventAliasName")]
            [Validation(Required=false)]
            public string AlarmEventAliasName { get; set; }

            /// <summary>
            /// <para>The description of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The detection model finds that self-mutation is running on your server. A self-mutation Trojan is a Trojan horse program with self-mutation function. It will change its hash or copy a large number of itself to different paths, and run in the background to avoid cleaning.</para>
            /// </summary>
            [NameInMap("AlarmEventDesc")]
            [Validation(Required=false)]
            public string AlarmEventDesc { get; set; }

            /// <summary>
            /// <para>The unique identifier of the alert event.</para>
            /// <remarks>
            /// <para>To query the details of an alert event, you must provide the unique identifier of the alert event. You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to obtain the identifier.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9f62555666f177aa84ee1eaf465a****</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// <para>The name of the container application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app:msdp-uat-service</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Indicates whether the online handling of the alert event is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// <para>Indicates whether you can cancel marking the alert event as a false positive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// <para>An array consisting of the cause of the alert event, which can be used to trace the alert event.</para>
            /// </summary>
            [NameInMap("CauseDetails")]
            [Validation(Required=false)]
            public List<DescribeAlarmEventDetailResponseBodyDataCauseDetails> CauseDetails { get; set; }
            public class DescribeAlarmEventDetailResponseBodyDataCauseDetails : TeaModel {
                /// <summary>
                /// <para>The key that is used to trace the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>842e314e69b1a2c45d5c1a2f88a16***</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value that is used to trace the alert event.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue> Value { get; set; }
                public class DescribeAlarmEventDetailResponseBodyDataCauseDetailsValue : TeaModel {
                    /// <summary>
                    /// <para>The name of the field that displays the tracing information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sshd</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the field that displays the tracing information. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>text</b></description></item>
                    /// <item><description><b>html</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>html</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the field that displays the tracing information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>under a certain small probability, yundun may mistakenly judge the repeated attempts caused by the administrator forgetting or entering the wrong password as successful blasting. Please check according to the account number and time shown in the alarm details. Once it is confirmed that it is not the initiative of the administrator, it is recommended to immediately block the IP, and you can open it at the same time<a href="https://yundun.console.aliyun.com/?p=pam">PAM</a>, hosting host login password, improving remote connection efficiency and security control ability, and according to<a href="https://click.aliyun.com/m/1000226086/">best practice of ECS account security protection</a>Modify login password and convergence asset.</para>↵
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the Safeguard Mode For Major Activities mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// <para>The ID of the container application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container_1606995441910_394868_01_000***</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The ID of the image to which the container belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cadb7a725641</para>
            /// </summary>
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            /// <summary>
            /// <para>The name of the image to which the container belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jenkins/jenkins:latest</para>
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// <para>The data source of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis_***</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert event ends. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1542366542000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz92q7m5hsbgfhdss***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.30.**</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The ID of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c562cf0d68e9749ee9fe544a7ab2f****</para>
            /// </summary>
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestK8sCluser</para>
            /// </summary>
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }

            /// <summary>
            /// <para>The namespace of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sit-saic-trip</para>
            /// </summary>
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            /// <summary>
            /// <para>The ID of the Kubernetes cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp14a1ay8e0aa9t0l***</para>
            /// </summary>
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou.10.188.139.**</para>
            /// </summary>
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myapp-pod</para>
            /// </summary>
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            /// <summary>
            /// <para>The severity of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b></description></item>
            /// <item><description><b>suspicious</b></description></item>
            /// <item><description><b>remind</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The solution to the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An invalid logon source IP has been detected. If you recognize this logon attempt, we recommend that you add the current logon source IP to the valid logon source IP list to avoid future alerts. If you do not recognize this logon attempt, we recommend that you modify the password.</para>
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert event starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1542378601000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The alert type of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Suspicious process</description></item>
            /// <item><description>Webshell</description></item>
            /// <item><description>Unusual logon</description></item>
            /// <item><description>Exception</description></item>
            /// <item><description>Sensitive file tampering</description></item>
            /// <item><description>Malicious process (cloud threat detection)</description></item>
            /// <item><description>Suspicious network connection</description></item>
            /// <item><description>Other</description></item>
            /// <item><description>Abnormal account</description></item>
            /// <item><description>Application intrusion event</description></item>
            /// <item><description>Cloud threat detection</description></item>
            /// <item><description>Precise defense</description></item>
            /// <item><description>Application whitelist</description></item>
            /// <item><description>Persistent webshell</description></item>
            /// <item><description>Web application threat detection</description></item>
            /// <item><description>Malicious script</description></item>
            /// <item><description>Threat intelligence</description></item>
            /// <item><description>Malicious network activity</description></item>
            /// <item><description>Cluster exception</description></item>
            /// <item><description>Webshell (on-premises threat detection)</description></item>
            /// <item><description>Vulnerability exploitation</description></item>
            /// <item><description>Malicious process (on-premises threat detection)</description></item>
            /// <item><description>Trusted exception</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Webshell</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The instance UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7EA50837-2F0B-5BCC-AB61-4968D88D75AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
