// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateParameterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the common parameter.</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public UpdateParameterResponseBodyParameter Parameter { get; set; }
        public class UpdateParameterResponseBodyParameter : TeaModel {
            /// <summary>
            /// <para>The constraints of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;AllowedValues\&quot;:[\&quot;parameter\&quot;],\&quot;AllowedPattern\&quot;:\&quot;parameter\&quot;,\&quot;MinLength\&quot;:0,\&quot;MaxLength\&quot;:20}&quot;</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public string Constraints { get; set; }

            /// <summary>
            /// <para>The user who created the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the common parameter was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-01T08:01:43Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>update</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The parameter ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-4c4b401cab6747xxxxxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyParameter</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version number of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public int? ParameterVersion { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The share type of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The tag added to the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;: &quot;v1&quot;, &quot;k2&quot;: &quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The data type of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user who updated the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the common parameter was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-01T08:04:23Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF1AE6DE-61C4-435E-8687-072CFACCCEC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
