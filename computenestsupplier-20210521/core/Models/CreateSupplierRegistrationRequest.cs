// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateSupplierRegistrationRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the contact person.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@xxx.com">xxxx@xxx.com</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>The phone number of the contact person.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186xxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// <para>The contact person.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Doe</para>
        /// </summary>
        [NameInMap("ContactPerson")]
        [Validation(Required=false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// <para>The title of the contact person.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CTO</para>
        /// </summary>
        [NameInMap("ContactPersonTitle")]
        [Validation(Required=false)]
        public string ContactPersonTitle { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableResellerMode")]
        [Validation(Required=false)]
        public bool? EnableResellerMode { get; set; }

        /// <summary>
        /// <para>The annual revenue of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000000</para>
        /// </summary>
        [NameInMap("ProductAnnualRevenue")]
        [Validation(Required=false)]
        public string ProductAnnualRevenue { get; set; }

        /// <summary>
        /// <para>The industry of the service provider\&quot;s product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("ProductBusiness")]
        [Validation(Required=false)]
        public string ProductBusiness { get; set; }

        /// <summary>
        /// <para>The delivery methods of the service provider\&quot;s product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SaaS</para>
        /// </description></item>
        /// <item><description><para>License</para>
        /// </description></item>
        /// <item><description><para>API</para>
        /// </description></item>
        /// <item><description><para>DesktopSoftware</para>
        /// </description></item>
        /// <item><description><para>Others</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProductDeliveryTypes")]
        [Validation(Required=false)]
        public List<string> ProductDeliveryTypes { get; set; }

        /// <summary>
        /// <para>The launch date of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020.10.10</para>
        /// </summary>
        [NameInMap("ProductPublishTime")]
        [Validation(Required=false)]
        public string ProductPublishTime { get; set; }

        /// <summary>
        /// <para>The sales models of the service provider\&quot;s product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Direct: Direct sales</para>
        /// </description></item>
        /// <item><description><para>Channel: Channel sales</para>
        /// </description></item>
        /// </list>
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
        /// <para>The description of the distribution business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ResellBusinessDesc")]
        [Validation(Required=false)]
        public string ResellBusinessDesc { get; set; }

        /// <summary>
        /// <para>The suggestions from the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        /// <summary>
        /// <para>The description of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Compute Nest</para>
        /// </summary>
        [NameInMap("SupplierDesc")]
        [Validation(Required=false)]
        public string SupplierDesc { get; set; }

        /// <summary>
        /// <para>The icon of the service provider.</para>
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
        /// <para>Company A</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <para>The English name of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("SupplierNameEn")]
        [Validation(Required=false)]
        public string SupplierNameEn { get; set; }

        /// <summary>
        /// <para>The supplier\&quot;s address.</para>
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
