// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ValidateNormalizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The storage mode for extended fields. Valid values: \<c>flat\\</c>, \<c>pack\\</c>, and \<c>reject\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flat</para>
        /// </summary>
        [NameInMap("ExtendFieldStoreMode")]
        [Validation(Required=false)]
        public string ExtendFieldStoreMode { get; set; }

        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sample log. The value must be in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;aaa&quot;:&quot;bbb&quot;,&quot;xxx&quot;:&quot;yyy&quot;}</para>
        /// </summary>
        [NameInMap("LogSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The normalization category of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY</para>
        /// </summary>
        [NameInMap("NormalizationCategoryId")]
        [Validation(Required=false)]
        public string NormalizationCategoryId { get; set; }

        /// <summary>
        /// <para>The expression for the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NormalizationRuleExpression")]
        [Validation(Required=false)]
        public string NormalizationRuleExpression { get; set; }

        /// <summary>
        /// <para>The mode of the normalization rule. Valid values: \<c>both\\</c> and \<c>realtime\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("NormalizationRuleMode")]
        [Validation(Required=false)]
        public string NormalizationRuleMode { get; set; }

        /// <summary>
        /// <para>The ID of the normalization pattern for the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is deployed. Select the region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. An administrator uses this parameter to switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The vendor ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
