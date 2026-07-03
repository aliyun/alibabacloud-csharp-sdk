// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class SetDefaultNormalizationRuleVersionRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The normalization rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nr-z0b2ssjteut85uoh9nzp</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <para>The normalization rule version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("NormalizationRuleVersion")]
        [Validation(Required=false)]
        public int? NormalizationRuleVersion { get; set; }

        /// <summary>
        /// <para>The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
