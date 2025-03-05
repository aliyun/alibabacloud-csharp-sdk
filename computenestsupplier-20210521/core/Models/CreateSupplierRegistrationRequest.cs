// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateSupplierRegistrationRequest : TeaModel {
        /// <summary>
        /// <para>Contact email</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@xxx.com">xxxx@xxx.com</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>Contact number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186xxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// <para>Contact person</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mike</para>
        /// </summary>
        [NameInMap("ContactPerson")]
        [Validation(Required=false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// <para>Contact person tiltle</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CTO</para>
        /// </summary>
        [NameInMap("ContactPersonTitle")]
        [Validation(Required=false)]
        public string ContactPersonTitle { get; set; }

        /// <summary>
        /// <para>Whether to enable the resell mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableResellerMode")]
        [Validation(Required=false)]
        public bool? EnableResellerMode { get; set; }

        /// <summary>
        /// <para>Annual product revenue</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProductAnnualRevenue")]
        [Validation(Required=false)]
        public string ProductAnnualRevenue { get; set; }

        /// <summary>
        /// <para>The business of product</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("ProductBusiness")]
        [Validation(Required=false)]
        public string ProductBusiness { get; set; }

        /// <summary>
        /// <para>Product delivery type</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductDeliveryTypes")]
        [Validation(Required=false)]
        public List<string> ProductDeliveryTypes { get; set; }

        /// <summary>
        /// <para>The publish time of product</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020.10.10</para>
        /// </summary>
        [NameInMap("ProductPublishTime")]
        [Validation(Required=false)]
        public string ProductPublishTime { get; set; }

        /// <summary>
        /// <para>Product sell type</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductSellTypes")]
        [Validation(Required=false)]
        public List<string> ProductSellTypes { get; set; }

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
        /// <para>The description of resell business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>empty</para>
        /// </summary>
        [NameInMap("ResellBusinessDesc")]
        [Validation(Required=false)]
        public string ResellBusinessDesc { get; set; }

        /// <summary>
        /// <para>The demands of service providers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>empty</para>
        /// </summary>
        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// <para>The description of service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test supplier</para>
        /// </summary>
        [NameInMap("SupplierDesc")]
        [Validation(Required=false)]
        public string SupplierDesc { get; set; }

        /// <summary>
        /// <para>The Logo of service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/cover/34DB-4F4C-9373-003AA060****.png">http://example.aliyundoc.com/cover/34DB-4F4C-9373-003AA060****.png</a></para>
        /// </summary>
        [NameInMap("SupplierLogo")]
        [Validation(Required=false)]
        public string SupplierLogo { get; set; }

        /// <summary>
        /// <para>The name of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <para>The english name of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("SupplierNameEn")]
        [Validation(Required=false)]
        public string SupplierNameEn { get; set; }

        /// <summary>
        /// <para>The URL of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.xxx.xxx.cn">http://www.xxx.xxx.cn</a></para>
        /// </summary>
        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

    }

}
