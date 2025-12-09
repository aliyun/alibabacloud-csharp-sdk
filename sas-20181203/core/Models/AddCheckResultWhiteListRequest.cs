// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCheckResultWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the check items.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to query the IDs of the check items.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// <para>IDs of the cloud product instances that need to be whitelisted. Separate multiple IDs with a comma (,).</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The description. The value of this parameter can be up to 65,535 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The type of the rule. Default value: <b>WHITE</b>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>WHITE</b>: Add check items to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
