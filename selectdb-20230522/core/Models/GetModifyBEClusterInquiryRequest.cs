// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class GetModifyBEClusterInquiryRequest : TeaModel {
        /// <summary>
        /// <para>The size of the elastic cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CacheSize")]
        [Validation(Required=false)]
        public long? CacheSize { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: subscription</description></item>
        /// <item><description>POSTPAY: pay-as-you-go</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-xxx-be</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>selectdb_pre_public_intl: subscription commodity on the international site (alibabacloud.com)</description></item>
        /// <item><description>selectdb_go_public_cn: pay-as-you-go commodity on the China site (aliyun.com)</description></item>
        /// <item><description>selectdb_go_public_intl: pay-as-you-go commodity on the international site (alibabacloud.com)</description></item>
        /// <item><description>selectdb_pre_public_cn: subscription commodity on the China site (aliyun.com)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb_go_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The number of elastic CPU cores.</para>
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

        [NameInMap("ModifyClusterChargeType")]
        [Validation(Required=false)]
        public bool? ModifyClusterChargeType { get; set; }

        /// <summary>
        /// <para>The size of the reserved cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PreCacheSize")]
        [Validation(Required=false)]
        public long? PreCacheSize { get; set; }

        /// <summary>
        /// <para>The number of reserved CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PreComputeSize")]
        [Validation(Required=false)]
        public long? PreComputeSize { get; set; }

        /// <summary>
        /// <para>The billing cycle.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Minute</description></item>
        /// <item><description>Hour</description></item>
        /// <item><description>Day</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The number of clusters whose specifications are to be changed.</para>
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
