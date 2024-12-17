// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new name of the instance. The name must be 2 to 80 characters in length. The name must start with a letter and cannot contain spaces and the following special characters: <c>@ / : = &quot; &lt; &gt; { [ ] }</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>newinstancename</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/165005.html">The release protection state of the instance.</a> Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled</description></item>
        /// <item><description><b>false</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InstanceReleaseProtection")]
        [Validation(Required=false)]
        public bool? InstanceReleaseProtection { get; set; }

        /// <summary>
        /// <para>The new password for the default account. The default account is named after the instance ID. Example: r-bp10noxlhcoim2\<em>\</em>\<em>\</em>.</para>
        /// <remarks>
        /// <para>The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. These special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>uW8+nsrp</para>
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
