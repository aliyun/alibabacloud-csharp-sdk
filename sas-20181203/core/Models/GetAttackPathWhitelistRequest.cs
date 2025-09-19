// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackPathWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>Attack path whitelist ID.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAttackPathWhitelist~~">ListAttackPathWhitelist</a> to query the attack path whitelist ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apwl-b33dec0acf9b42aabde032d656c0****</para>
        /// </summary>
        [NameInMap("AttackPathWhitelistId")]
        [Validation(Required=false)]
        public string AttackPathWhitelistId { get; set; }

    }

}
