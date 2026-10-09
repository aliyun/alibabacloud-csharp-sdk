// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateSelectionKeyByTypeRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the asset selection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: virus scan cycle configuration</description></item>
        /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: one-time virus scan task</description></item>
        /// <item><description><b>AGENTLESS_MALICIOUS_WHITE_LIST_[ID]</b>: agentless detection alert whitelist rule</description></item>
        /// <item><description><b>AGENTLESS_VUL_WHITE_LIST_[ID]</b>: agentless detection vulnerability whitelist rule</description></item>
        /// <item><description><b>FILE_PROTECT_RULE_SWITCH_TYPE_[ID]</b>: core file protection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_SCAN_CYCLE_CONFIG</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request. Use a different token for different requests. Only ASCII characters are supported. The token can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run without executing the actual operation.</description></item>
        /// <item><description>false: executes the request normally.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The unique identifier of the asset selection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>614d179e-4776-4939-a04a-d842ce64****</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

    }

}
