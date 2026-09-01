// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the asset selection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: trojan scan configuration.</description></item>
        /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: trojan scan one-time scan.</description></item>
        /// <item><description><b>AGENTLESS_MALICIOUS_WHITE_LIST_[ID]</b>: agentless detection alert whitelisting rule.</description></item>
        /// <item><description><b>AGENTLESS_VUL_WHITE_LIST_[ID]</b>: agentless detection vulnerability whitelisting rule.</description></item>
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

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The operating system of the target asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all operating systems.</description></item>
        /// <item><description><b>windows</b>: Windows operating system.</description></item>
        /// <item><description><b>linux</b>: Linux operating system.<remarks>
        /// <para>If this parameter is left empty, the default value is determined based on the <b>BusinessType</b> value.</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: the value is <b>all</b>.</description></item>
        /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: the value is <b>all</b>.</description></item>
        /// <item><description><b>AGENTLESS_MALICIOUS_WHITE_LIST_[ID]</b>: the value is <b>all</b>.</description></item>
        /// <item><description><b>AGENTLESS_VUL_WHITE_LIST_[ID]</b>: the value is <b>all</b>.</description></item>
        /// <item><description><b>FILE_PROTECT_RULE_SWITCH_TYPE_[ID]</b>: the value is <b>linux</b>.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The target asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all_instance</b>: all servers.</description></item>
        /// <item><description><b>instance</b>: select by server.</description></item>
        /// <item><description><b>group</b>: select by group.</description></item>
        /// <item><description><b>vpc</b>: select by VPC.</description></item>
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
