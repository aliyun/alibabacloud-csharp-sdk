// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateSecretParameterRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). For more information, see &quot;How to ensure idempotence&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The constraints of the encryption parameter. By default, this parameter is null. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllowedValues: The value that is allowed for the encryption parameter. It must be an array string.</description></item>
        /// <item><description>AllowedPattern: The pattern that is allowed for the encryption parameter. It must be a regular expression.</description></item>
        /// <item><description>MinLength: The minimum length of the encryption parameter.</description></item>
        /// <item><description>MaxLength: The maximum length of the encryption parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;{\&quot;\&quot;AllowedValues&quot;:[&quot;secretparameter&quot;],&quot;AllowedPattern&quot;:&quot;secretparameter&quot;,&quot;MinLength&quot;:0,&quot;MaxLength&quot;:20}\&quot;</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

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
        /// <para>The description of the encryption parameter. The description must be 1 to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecretParameter</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The key ID of Key Management Service (KMS) that is used to encrypt the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80e9409f-78fa-42ab-84bd-83f40c******</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The name of the parameter. The name must be 1 to 180 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). It cannot start with ALIYUN, ACS, ALIBABA, ALICLOUD, or OOS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySecretParameter</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;: &quot;v1&quot;, &quot;k2&quot;: &quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The type of the parameter. Set the value to Secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secret</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value of the encryption parameter. The value must be 1 to 4096 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecretParameter</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
