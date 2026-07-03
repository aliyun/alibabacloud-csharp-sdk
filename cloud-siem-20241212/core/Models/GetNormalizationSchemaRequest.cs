// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationSchemaRequest : TeaModel {
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
        /// <para>The ID of the normalization rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP_ACTIVITY</para>
        /// </summary>
        [NameInMap("NormalizationSchemaId")]
        [Validation(Required=false)]
        public string NormalizationSchemaId { get; set; }

        /// <summary>
        /// <para>The normalization schema type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>log: log.</description></item>
        /// <item><description>entity: entity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("NormalizationSchemaType")]
        [Validation(Required=false)]
        public string NormalizationSchemaType { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis data management center resides. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to when viewing as another member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
