// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which data is automatically archived after the storage expires. Valid values: 60, 90, 180, and 365. 0 indicates that the data is not archived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ArchiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <para>The IP addresses or CIDR blocks for which password-free read is enabled. Separate multiple IP addresses with line breaks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthFreeReadPolicy")]
        [Validation(Required=false)]
        public string AuthFreeReadPolicy { get; set; }

        /// <summary>
        /// <para>The IP addresses or CIDR blocks for which password-free write is enabled. Separate multiple IP addresses with line breaks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthFreeWritePolicy")]
        [Validation(Required=false)]
        public string AuthFreeWritePolicy { get; set; }

        /// <summary>
        /// <para>The ID of the Prometheus instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free read.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free write.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access token authentication.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>The billing mode. Valid values: POSTPAY: charges fees based on the amount of reported metric data. POSTPAY_GB: charges fees based on the amount of written metric data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Prometheus resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The data storage duration. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("StorageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

    }

}
