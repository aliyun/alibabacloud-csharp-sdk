// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAttackPathWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The attack path whitelist.</para>
        /// </summary>
        [NameInMap("AttackPathWhitelist")]
        [Validation(Required=false)]
        public CreateAttackPathWhitelistResponseBodyAttackPathWhitelist AttackPathWhitelist { get; set; }
        public class CreateAttackPathWhitelistResponseBodyAttackPathWhitelist : TeaModel {
            /// <summary>
            /// <para>The ID of the attack path whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apwl-b33dec0acf9b42aabde032d656c0****</para>
            /// </summary>
            [NameInMap("AttackPathWhitelistId")]
            [Validation(Required=false)]
            public string AttackPathWhitelistId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
