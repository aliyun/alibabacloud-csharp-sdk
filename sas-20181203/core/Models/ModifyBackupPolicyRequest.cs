// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the anti-ransomware policy to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the anti-ransomware policy to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_name_A</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The content of the policy to modify. The value is a JSON format character string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Source</b>: The server folder to protect. To protect all folders, set this field to [].</para>
        /// </description></item>
        /// <item><description><para><b>Include</b>: The file types to protect. Examples: &quot;\<em>.jpg&quot; and &quot;\</em>.doc&quot;.</para>
        /// </description></item>
        /// <item><description><para><b>Exclude</b>: The custom folders to exclude. For example, &quot;/home/user&quot; excludes the /home/user folder. Invoke the DescribeExcludeSystemPath operation to obtain all folders, and then add the folders that you want to exclude.</para>
        /// </description></item>
        /// <item><description><para><b>Schedule</b>: The start time and interval of the data backup node. Specify a non-hourly time during off-peak hours.</para>
        /// <list type="bullet">
        /// <item><description><para>Example 1: I|1583216092|P21D indicates that the execute start time is 2020-03-03 14:14:52 and the interval is 3 weeks.</para>
        /// </description></item>
        /// <item><description><para>Example 2: I|1583216092|PT24H indicates that the execute start time is 2020-03-03 14:14:52 and the interval is 24 hours.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Retention</b>: The retention period of backup data. Unit: days. 7 indicates 1 week, 365 indicates 1 year, and -1 indicates permanent retention.</para>
        /// </description></item>
        /// <item><description><para><b>SpeedLimiter</b>: The network bandwidth throttling for backup. For example, 12:15:15360|6:12:5120 indicates 15 MB from 12:00 to 15:00 and 5 MB from 6:00 to 12:00.
        /// For cloud-based servers connected to the internal network, do not limit the backup network bandwidth. To remove the network bandwidth throttling, set this parameter to an empty character string (&quot;&quot;).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Source&quot;:[&quot;home&quot;,&quot;admin&quot;]}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public Dictionary<string, object> Policy { get; set; }

        /// <summary>
        /// <para>The region of the server for which you want to modify the policy.</para>
        /// <para>You can invoke the <a href="~~DescribeSupportRegion~~">DescribeSupportRegion</a> operation to query the regions supported by the anti-ransomware feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("PolicyRegionId")]
        [Validation(Required=false)]
        public string PolicyRegionId { get; set; }

        /// <summary>
        /// <para>The version of the policy. You can invoke the <a href="~~DescribeBackupPolicies~~">DescribeBackupPolicies</a> operation to query the version.</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b></description></item>
        /// <item><description><b>2.0.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// <para>The method used to select assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_MACHINE</b>: all assets<remarks>
        /// <para>To cover all assets of the specified type, set this parameter to <b>ALL_MACHINE</b>. In this case, <b>UuidList</b> is invalid. Only one policy that covers all assets can exist for each server type.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_MACHINE</para>
        /// </summary>
        [NameInMap("SelectType")]
        [Validation(Required=false)]
        public string SelectType { get; set; }

        /// <summary>
        /// <para>The server type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud server</description></item>
        /// <item><description><b>OUT_CLOUD</b>: non-Alibaba Cloud server</description></item>
        /// <item><description><b>TRIPARTITE</b>: simple application server</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of the servers protected by the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;, &quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;]</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
