// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeNodePoolVulsResponseBody : TeaModel {
        /// <summary>
        /// <para>The node pool vulnerabilities.</para>
        /// </summary>
        [NameInMap("vul_records")]
        [Validation(Required=false)]
        public List<DescribeNodePoolVulsResponseBodyVulRecords> VulRecords { get; set; }
        public class DescribeNodePoolVulsResponseBodyVulRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-t4n2qolb0wtzt0pz****</para>
            /// </summary>
            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The node name. This name is the identifier of the node in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou.192.168.x.x</para>
            /// </summary>
            [NameInMap("node_name")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>A list of vulnerabilities.</para>
            /// </summary>
            [NameInMap("vul_list")]
            [Validation(Required=false)]
            public List<DescribeNodePoolVulsResponseBodyVulRecordsVulList> VulList { get; set; }
            public class DescribeNodePoolVulsResponseBodyVulRecordsVulList : TeaModel {
                /// <summary>
                /// <para>The alias of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RHSA-2019:3197-Important: sudo security update</para>
                /// </summary>
                [NameInMap("alias_name")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>A list of CVE names corresponding to the vulnerabilities.</para>
                /// </summary>
                [NameInMap("cve_list")]
                [Validation(Required=false)]
                public List<string> CveList { get; set; }

                /// <summary>
                /// <para>The name of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oval:com.redhat.rhsa:def:20193197</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The severity level of the vulnerability.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>nntf: You can ignore the vulnerability.</description></item>
                /// <item><description>later: You can fix the vulnerability later.</description></item>
                /// <item><description>asap: You need to fix the vulnerability at the earliest opportunity.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>asap</para>
                /// </summary>
                [NameInMap("necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart is required.</para>
                /// </summary>
                [NameInMap("need_reboot")]
                [Validation(Required=false)]
                public bool? NeedReboot { get; set; }

            }

        }

        /// <summary>
        /// <para>Whether the Cloud Security CVE Remediation Service has been purchased</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("vuls_fix_service_purchased")]
        [Validation(Required=false)]
        public bool? VulsFixServicePurchased { get; set; }

    }

}
