// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the first page to return. Default value: 1, which indicates that results are returned starting from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The identification information of the server that is protected by the anti-ransomware policy you want to query. You can enter the IP address or instance ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The name of the anti-ransomware mitigation policy that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecurityStrategy-20200303</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of backup policies per page in a paged query. Default value: 10, which indicates that each page contains 10 mitigation policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the anti-ransomware mitigation policy.</para>
        /// <list type="bullet">
        /// <item><description><para><b>enabled</b>: The policy is manually enabled.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: The policy is manually disabled. After the policy is disabled, running backup nodes are stopped.</para>
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
