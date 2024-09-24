// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The feature that you want to select for the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: virus detection and removal</description></item>
        /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: one-time scan for viruses</description></item>
        /// <item><description><b>AGENTLESS_MALICIOUS_WHITE_LIST_[ID]</b>: a whitelist rule for alerts that are detected by using the agentless detection feature</description></item>
        /// <item><description><b>AGENTLESS_VUL_WHITE_LIST_[ID]</b>: a whitelist rule for vulnerabilities that are detected by using the agentless detection feature</description></item>
        /// <item><description><b>FILE_PROTECT_RULE_SWITCH_TYPE_[ID]</b>: core file protection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_SCAN_CYCLE_CONFIG</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The dimension based on which you want to select the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instance</b>: selects the asset by server.</description></item>
        /// <item><description><b>group</b>: selects the asset by group.</description></item>
        /// <item><description><b>vpc</b>: selects the asset by virtual private cloud (VPC).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
