// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DedicatedIpAutoRenewalRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable auto-renewal</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public string AutoRenewal { get; set; }

        /// <summary>
        /// <para>Purchase instance ID, separated by English commas if multiple.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx,xxx</para>
        /// </summary>
        [NameInMap("BuyResourceIds")]
        [Validation(Required=false)]
        public string BuyResourceIds { get; set; }

    }

}
