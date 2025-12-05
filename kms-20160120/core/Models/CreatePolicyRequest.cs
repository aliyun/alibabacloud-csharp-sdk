// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the access control rule.</para>
        /// <remarks>
        /// <para>For more information about how to query created access control rules, see <a href="https://help.aliyun.com/document_detail/2539433.html">ListNetworkRules</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NetworkRules&quot;:[&quot;kst-hzz62ee817bvyyr5x****.efkd&quot;,&quot;kst-hzz62ee817bvyyr5x****.eyyp&quot;]}</para>
        /// </summary>
        [NameInMap("AccessControlRules")]
        [Validation(Required=false)]
        public string AccessControlRules { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy  description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scope of the permission policy. You need to specify the KMS instance that you want to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-hzz634e67d126u9p9****</para>
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public string KmsInstance { get; set; }

        /// <summary>
        /// <para>The name of the permission policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operations that can be performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RbacPermission/Template/CryptoServiceKeyUser: allows you to perform cryptographic operations.</description></item>
        /// <item><description>RbacPermission/Template/CryptoServiceSecretUser: allows you to perform secret-related operations.</description></item>
        /// </list>
        /// <para>You can select both.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;RbacPermission/Template/CryptoServiceKeyUser&quot;, &quot;RbacPermission/Template/CryptoServiceSecretUser&quot;]</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// <para>The key and secret that are allowed to access.</para>
        /// <list type="bullet">
        /// <item><description>Key: Enter a key in the <c>key/${KeyId}</c> format. To allow access to all keys of a KMS instance, enter key/\*.</description></item>
        /// <item><description>Secret: Enter a secret in the <c>secret/${SecretName}</c> format. To allow access to all secrets of a KMS instance, enter secret/\*.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;secret/acs/ram/user/ram-secret&quot;, &quot;secret/acs/ram/user/acr-master&quot;, &quot;key/key-hzz63d9c8d3dfv8cv****&quot;]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
