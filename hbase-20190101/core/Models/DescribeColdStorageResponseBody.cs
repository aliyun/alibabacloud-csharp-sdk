// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeColdStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1uoihlf82e8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The total storage capacity of cold storage, in GB.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>OpenStatus</b> is <b>open</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public string ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The cold storage type. For newly created BDS instances, the cold storage type is <b>BdsColdStorage</b>. This parameter is not returned for other instances by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BdsColdStorage</para>
        /// </summary>
        [NameInMap("ColdStorageType")]
        [Validation(Required=false)]
        public string ColdStorageType { get; set; }

        /// <summary>
        /// <para>The amount of cold storage space used, in GB.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>OpenStatus</b> is <b>open</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("ColdStorageUseAmount")]
        [Validation(Required=false)]
        public string ColdStorageUseAmount { get; set; }

        /// <summary>
        /// <para>The usage of the cold storage space, in percentage (%).</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>OpenStatus</b> is <b>open</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("ColdStorageUsePercent")]
        [Validation(Required=false)]
        public string ColdStorageUsePercent { get; set; }

        /// <summary>
        /// <para>The enabling status of cold storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: Cold storage is enabled.</description></item>
        /// <item><description><b>close</b>: Cold storage is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public string OpenStatus { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DCB9479E-F05F-4D1C-AFB7-C639B87764B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
