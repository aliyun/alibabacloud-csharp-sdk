// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the asset selection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: trojan scan configuration</description></item>
        /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: trojan scan one-time scan</description></item>
        /// <item><description><b>AGENTLESS_MALICIOUS_WHITE_LIST_[ID]</b>: agentless detection alert whitelisting rule</description></item>
        /// <item><description><b>AGENTLESS_VUL_WHITE_LIST_[ID]</b>: agentless detection vulnerability whitelisting rule</description></item>
        /// <item><description><b>FILE_PROTECT_RULE_SWITCH_TYPE_[ID]</b>: core file protection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_SCAN_CYCLE_CONFIG</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

    }

}
