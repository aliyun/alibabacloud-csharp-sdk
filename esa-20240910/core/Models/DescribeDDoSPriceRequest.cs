// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSPriceRequest : TeaModel {
        /// <summary>
        /// <para>The billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CleanTraffic</para>
        /// </summary>
        [NameInMap("DDoSBillingMode")]
        [Validation(Required=false)]
        public string DDoSBillingMode { get; set; }

        /// <summary>
        /// <para>The instance specifications for the Chinese mainland.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn_300</para>
        /// </summary>
        [NameInMap("DDoSBurstableDomesticProtection")]
        [Validation(Required=false)]
        public string DDoSBurstableDomesticProtection { get; set; }

        /// <summary>
        /// <para>The instance specifications for regions outside the Chinese mainland.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>overseas_300</para>
        /// </summary>
        [NameInMap("DDoSBurstableOverseasProtection")]
        [Validation(Required=false)]
        public string DDoSBurstableOverseasProtection { get; set; }

    }

}
