// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of servers with alerts.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningMachineResponseBodyList> List { get; set; }
        public class ListCheckItemWarningMachineResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The type of the cloud service asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The authorization version of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition</description></item>
            /// <item><description><b>5</b>: Premium Edition</description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// <item><description><b>10</b>: Value-added Service Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is bound to an authorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The asset is bound to an authorization.</description></item>
            /// <item><description><b>false</b>: The asset is not bound to an authorization.</description></item>
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
            /// <para>The list of fixable baselines in which the risk of this check item is detected.</para>
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
            /// <para>Indicates whether fixing is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not supported</description></item>
            /// <item><description><b>1</b>: supported</description></item>
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
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the affected asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the affected asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest handling of the check item risk on the server. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694692471000</para>
            /// </summary>
            [NameInMap("LastHandleTime")]
            [Validation(Required=false)]
            public long? LastHandleTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694692471000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the server has ports open to the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The server has ports open to the Internet.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The server does not have ports open to the Internet.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PortOpen")]
            [Validation(Required=false)]
            public bool? PortOpen { get; set; }

            /// <summary>
            /// <para>The check prompt for the baseline check risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>There is a weak password (username/password): root/he*****34</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The ID of the region where the asset resides.</para>
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
            /// <para>The ID of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the scan target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jenkins****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_SNAPSHOT</b>: snapshot</description></item>
            /// <item><description><b>ECS_IMAGE</b>: image</description></item>
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
            /// <para>The list of baselines in which the risk of this check item is detected.</para>
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
        /// <para>The pagination information of the query results.</para>
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
            /// <para>The page number of the current page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries displayed on each page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of affected assets returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22B5615F-700E-575A-A6D5-DC8D7741****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
