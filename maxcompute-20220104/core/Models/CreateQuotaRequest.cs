// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payasyougo</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;CU&quot;:50,&quot;ord_time&quot;:&quot;1:Month&quot;,&quot;autoRenew&quot;:false}</para>
        /// </summary>
        [NameInMap("commodityData")]
        [Validation(Required=false)]
        public string CommodityData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyQuota</para>
        /// </summary>
        [NameInMap("partNickName")]
        [Validation(Required=false)]
        public string PartNickName { get; set; }

    }

}
