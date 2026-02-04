// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ValidateNormalizationRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flat</para>
        /// </summary>
        [NameInMap("ExtendFieldStoreMode")]
        [Validation(Required=false)]
        public string ExtendFieldStoreMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;aaa&quot;:&quot;bbb&quot;,&quot;xxx&quot;:&quot;yyy&quot;}</para>
        /// </summary>
        [NameInMap("LogSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY。</para>
        /// </summary>
        [NameInMap("NormalizationCategoryId")]
        [Validation(Required=false)]
        public string NormalizationCategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NormalizationRuleExpression")]
        [Validation(Required=false)]
        public string NormalizationRuleExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("NormalizationRuleMode")]
        [Validation(Required=false)]
        public string NormalizationRuleMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP_ACTIVITY。</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
