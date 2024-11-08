// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>Invalid encryption parameter.</para>
        /// </summary>
        [NameInMap("InvalidParameters")]
        [Validation(Required=false)]
        public List<string> InvalidParameters { get; set; }

        /// <summary>
        /// <para>The information about the encryption parameter.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetSecretParametersResponseBodyParameters> Parameters { get; set; }
        public class GetSecretParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>The constraints of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;AllowedValues\&quot;: [\&quot;test\&quot;]}</para>
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
            /// <para>2020-10-22T03:11:13Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secretParameter</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-7cdc0000000000000000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ssh-bp67acfmxazb4p****</para>
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
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;: &quot;v1&quot;, &quot;k2&quot;: &quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The data type of the encryption parameter.</para>
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
            /// <para>2020-10-22T03:11:13Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The value of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secretParameter,secretParameter1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5320F1D-92D9-44BB-A416-5FC525ED6D57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
