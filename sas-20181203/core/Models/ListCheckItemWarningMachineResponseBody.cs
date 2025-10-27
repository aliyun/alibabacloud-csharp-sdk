// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The servers on which the alerts are generated.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningMachineResponseBodyList> List { get; set; }
        public class ListCheckItemWarningMachineResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The edition of Security Center that is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic edition</description></item>
            /// <item><description><b>6</b>: Anti-virus edition</description></item>
            /// <item><description><b>5</b>: Advanced edition</description></item>
            /// <item><description><b>3</b>: Enterprise edition</description></item>
            /// <item><description><b>7</b>: Ultimate edition</description></item>
            /// <item><description><b>10</b>: Value-added Plan edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether Security Center is authorized to protect the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            /// <summary>
            /// <para>The ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48a6d9a92435a13ad573372c3f3c63b7e04d106458141df9f9215570********</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The name of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>step-build-ui-build</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The details of the baselines for which the risk item can be fixed.</para>
            /// </summary>
            [NameInMap("FixList")]
            [Validation(Required=false)]
            public List<ListCheckItemWarningMachineResponseBodyListFixList> FixList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListFixList : TeaModel {
                /// <summary>
                /// <para>The ID of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                public long? RiskId { get; set; }

                /// <summary>
                /// <para>The name of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Linux/Aliyun Linux 2 Baseline for China classified protection of cybersecurity-Level II</para>
                /// </summary>
                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

            }

            /// <summary>
            /// <para>Whether the repair is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Supported</description></item>
            /// <item><description><b>1</b>: Not Supported</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FixStatus")]
            [Validation(Required=false)]
            public int? FixStatus { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1a69mvjujbakxu****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest processing of the check item risk of the machine. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694692471000</para>
            /// </summary>
            [NameInMap("LastHandleTime")]
            [Validation(Required=false)]
            public long? LastHandleTime { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694692471000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>Indicates whether a port on the server is accessible over the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PortOpen")]
            [Validation(Required=false)]
            public bool? PortOpen { get; set; }

            /// <summary>
            /// <para>The prompt for the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There is a weak password (username/password): root/he*****34</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: failed</description></item>
            /// <item><description><b>2</b>: verifying</description></item>
            /// <item><description><b>3</b>: passed</description></item>
            /// <item><description><b>6</b>: ignored</description></item>
            /// <item><description><b>7</b>: fixing</description></item>
            /// <item><description><b>8</b>: fixed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the asset that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the asset on which the malicious image sample is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jenkins****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_SNAPSHOT</b></description></item>
            /// <item><description><b>ECS_IMAGE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The information about the baselines on which the risk item is detected.</para>
            /// </summary>
            [NameInMap("WarningRiskList")]
            [Validation(Required=false)]
            [Obsolete]
            public List<ListCheckItemWarningMachineResponseBodyListWarningRiskList> WarningRiskList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListWarningRiskList : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The ID of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                [Obsolete]
                public long? RiskId { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The name of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Linux/Aliyun Linux 2 Baseline for China classified protection of cybersecurity-Level II</para>
                /// </summary>
                [NameInMap("RiskName")]
                [Validation(Required=false)]
                [Obsolete]
                public string RiskName { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningMachineResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of affected assets returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of affected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22B5615F-700E-575A-A6D5-DC8D7741****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
