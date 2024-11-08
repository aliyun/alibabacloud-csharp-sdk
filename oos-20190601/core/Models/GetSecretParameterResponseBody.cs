// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParameterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the encryption parameter.</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public GetSecretParameterResponseBodyParameter Parameter { get; set; }
        public class GetSecretParameterResponseBodyParameter : TeaModel {
            /// <summary>
            /// <para>The constraints of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;{\&quot;\&quot;AllowedValues&quot;:[&quot;secretparameter&quot;],&quot;AllowedPattern&quot;:&quot;.*&quot;,&quot;MinLength&quot;:0,&quot;MaxLength&quot;:20}\&quot;</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public string Constraints { get; set; }

            /// <summary>
            /// <para>The user who created the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the encryption parameter was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-01T09:28:47Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The instance ID of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kst-hzz****</para>
            /// </summary>
            [NameInMap("DKMSInstanceId")]
            [Validation(Required=false)]
            public string DKMSInstanceId { get; set; }

            /// <summary>
            /// <para>The description of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecretParameter</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-14ed150fdcd048xxxxxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the key of Key Management Service (KMS) that is used for encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80e9409f-78fa-42ab-84bd-83f40c******</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The name of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySecretParameter</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version number of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public int? ParameterVersion { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The share type of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The tags of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;: &quot;v1&quot;, &quot;k2&quot;: &quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The type of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Secret</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user who updated the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the encryption parameter was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-01T09:35:17Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The value of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecretParameter</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F14FB7C-C9BE-44AE-92ED-21ACC02FBFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
