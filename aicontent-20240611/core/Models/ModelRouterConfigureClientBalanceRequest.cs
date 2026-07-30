// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterConfigureClientBalanceRequest : TeaModel {
        /// <summary>
        /// <para>The balance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>amount: monetary amount.</description></item>
        /// <item><description>tokens: token count.</description></item>
        /// </list>
        /// <para>This parameter is required when you enable balance throttling for the first time. Once set, it cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amount</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable balance-based throttling. Once enabled, balance throttling cannot be disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableBalance")]
        [Validation(Required=false)]
        public bool? EnableBalance { get; set; }

        /// <summary>
        /// <para>The initial balance. This parameter takes effect only when balance throttling is enabled for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("initialBalance")]
        [Validation(Required=false)]
        public double? InitialBalance { get; set; }

    }

}
