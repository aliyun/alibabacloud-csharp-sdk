// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class GetCreateBEClusterInquiryRequest : TeaModel {
        /// <summary>
        /// <para>The elastic cache space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CacheSize")]
        [Validation(Required=false)]
        public long? CacheSize { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb_go_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The elastic computing resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ComputeSize")]
        [Validation(Required=false)]
        public long? ComputeSize { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-xxx</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>The reserved cache space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PreCacheSize")]
        [Validation(Required=false)]
        public long? PreCacheSize { get; set; }

        /// <summary>
        /// <para>The reserved computing resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PreComputeSize")]
        [Validation(Required=false)]
        public long? PreComputeSize { get; set; }

        /// <summary>
        /// <para>The billing cycle.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2374923467</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The quantity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
