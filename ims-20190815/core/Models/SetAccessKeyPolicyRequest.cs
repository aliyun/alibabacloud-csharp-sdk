// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetAccessKeyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The network access restriction policy.</para>
        /// <para>A JSON-formatted string. For more information, see the AccessKeyPolicy structure description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Status&quot;:&quot;Inactive&quot;,&quot;Statements&quot;:[{&quot;Value&quot;:&quot;AllowAllVPC&quot;,&quot;Type&quot;:&quot;VPCWhiteList&quot;,&quot;IPList&quot;:[&quot;::/0&quot;,&quot;0.0.0.0/0&quot;]}]}</para>
        /// </summary>
        [NameInMap("AccessKeyPolicy")]
        [Validation(Required=false)]
        public string AccessKeyPolicy { get; set; }

        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI*******************</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user. </para>
        /// <para>If this parameter is left empty, the network access restriction policy is set for the specified AccessKey pair of the current user by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
