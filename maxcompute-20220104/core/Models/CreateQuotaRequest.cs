// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>Billing type. Use payasyougo for pay-as-you-go or subscription for subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payasyougo</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Product code. For example:
        /// Alibaba Cloud China Website (www\.aliyun.com): use odps for pay-as-you-go and odpsplus for subscription.
        /// Alibaba Cloud International Website (www\.alibabacloud.com): use odps_intl for pay-as-you-go and odpsplus_intl for subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>Quota specification.</para>
        /// <remarks>
        /// <para>Notice: Required only for subscription quotas.
        /// The minimum CU value is 50.
        /// ord_time supports month and year.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CU&quot;:50,&quot;ord_time&quot;:&quot;1:Month&quot;,&quot;autoRenew&quot;:false}</para>
        /// </summary>
        [NameInMap("commodityData")]
        [Validation(Required=false)]
        public string CommodityData { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Required only for subscription quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyQuota</para>
        /// </summary>
        [NameInMap("partNickName")]
        [Validation(Required=false)]
        public string PartNickName { get; set; }

    }

}
