// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreatePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NetworkRules&quot;:[&quot;kst-hzz62ee817bvyyr5x****.efkd&quot;,&quot;kst-hzz62ee817bvyyr5x****.eyyp&quot;]}</para>
        /// </summary>
        [NameInMap("AccessControlRules")]
        [Validation(Required=false)]
        public string AccessControlRules { get; set; }

        /// <summary>
        /// <para>The ARN of the permission policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:119285303511****:policy/policy_test</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

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
        /// <para>The scope of the permission policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-hzz634e67d126u9p9****</para>
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public string KmsInstance { get; set; }

        /// <summary>
        /// <para>The name of the permission policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operations that can be performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;RbacPermission/Template/CryptoServiceKeyUser&quot;, &quot;RbacPermission/Template/CryptoServiceSecretUser&quot;]</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3bf02f7a-015b-4f34-be0f-c4543fda2d33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The key and secret that are allowed to access.</para>
        /// <list type="bullet">
        /// <item><description><c>key/*</c> indicates that all keys of the KMS instance can be accessed.</description></item>
        /// <item><description><c>secret/*</c> indicates all secrets of the KMS instance can be accessed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;secret/acs/ram/user/ram-secret&quot;, &quot;secret/acs/ram/user/acr-master&quot;, &quot;key/key-hzz63d9c8d3dfv8cv****&quot;]</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
