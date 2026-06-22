// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The page number from which to start displaying the returned results. Default value: 1, which indicates that the display starts from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The identification information of the server protected by the anti-ransomware policy to query. You can enter the IP address or instance ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The name of the anti-ransomware protection policy to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecurityStrategy-20200303</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of backup policies on each page during paginated queries. Default value: 10, which indicates that each page contains 10 protection policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the anti-ransomware protection policy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>enabled</b>: The policy is manually enabled.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: The policy is manually disabled. After the policy is disabled, running backup tasks will stop.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: The anti-ransomware capacity is exceeded, and the system disables the policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
