// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC_WebSite</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal upon expiration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique value from your client. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210713a117660695309606626a</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPEN_SUBSCRIPTION</para>
        /// </summary>
        [NameInMap("CreateAction")]
        [Validation(Required=false)]
        public string CreateAction { get; set; }

        /// <summary>
        /// <para>The deployment region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseMainland</para>
        /// </summary>
        [NameInMap("DeployArea")]
        [Validation(Required=false)]
        public string DeployArea { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>go-to-the-docks-for-french-fries</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Required. The number of subscription periods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>docs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The payment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_PAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Required. The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year: year</description></item>
        /// <item><description>Month: month</description></item>
        /// <item><description>Day: day</description></item>
        /// <item><description>Hour: hour.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Required. The number of instances to subscribe to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2smovqqpvuly</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The website version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic_Edition</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public string SiteVersion { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-01</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
