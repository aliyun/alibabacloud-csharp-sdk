// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. Valid values: payasyougo (pay-as-you-go) and subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payasyougo</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The commodity code. Example: On Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>), the commodity code for pay-as-you-go is odps and the commodity code for subscription is odpsplus. On Alibaba Cloud International Website (<a href="http://www.alibabacloud.com">www.alibabacloud.com</a>), the commodity code for pay-as-you-go is odps_intl and the commodity code for subscription is odpsplus_intl.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The commodity specifications of the quota.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only for subscription quotas.
        /// The minimum unit for cu is 50.
        /// ord_time supports monthly (month) and yearly (year) billing.</para>
        /// </description></item>
        /// <item><description><para>After creation, commodityData cannot be modified. To modify it, go to the MaxCompute console.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CU&quot;:50,&quot;ord_time&quot;:&quot;1:Month&quot;,&quot;autoRenew&quot;:false}</para>
        /// </summary>
        [NameInMap("commodityData")]
        [Validation(Required=false)]
        public string CommodityData { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: This parameter is required only for subscription quotas.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyQuota</para>
        /// </summary>
        [NameInMap("partNickName")]
        [Validation(Required=false)]
        public string PartNickName { get; set; }

    }

}
