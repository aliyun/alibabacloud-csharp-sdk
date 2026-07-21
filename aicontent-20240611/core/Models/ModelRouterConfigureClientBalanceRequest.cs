// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterConfigureClientBalanceRequest : TeaModel {
        /// <summary>
        /// <para>The balance type. Valid values: <c>amount</c> or <c>tokens</c>. This parameter is required when you first enable balance throttling and cannot be changed afterward.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amount</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable balance throttling. Once enabled, this feature cannot be disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableBalance")]
        [Validation(Required=false)]
        public bool? EnableBalance { get; set; }

        /// <summary>
        /// <para>The initial balance. This parameter is only applicable when you first enable balance throttling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("initialBalance")]
        [Validation(Required=false)]
        public double? InitialBalance { get; set; }

    }

}
