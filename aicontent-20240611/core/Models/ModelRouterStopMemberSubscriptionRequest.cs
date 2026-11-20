// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterStopMemberSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The balance type. Valid values: permanent, monthly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>monthly</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

    }

}
