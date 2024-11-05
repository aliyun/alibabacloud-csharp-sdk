// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateUserPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the public key. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host on which you want to create a public key for the user.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204522.html">listinstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The public key. Encode the value by using the Base64 algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3NoLWVkMjU1MTkgQUFBQUMzTnphQzFsWkRJMU5URTVBQUFBSUxGQnQxUUpyT3IxK2hTTGRkbERMZUx4WGRIZ3hBalBxWHJIbWNFNWxqSk8gbm93Y29kZXJAbm93Y29kZXJkZU1hY0Jvb2stUHJvLmxvY2Fs</para>
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// <para>The name of the public key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public key of a user</para>
        /// </summary>
        [NameInMap("PublicKeyName")]
        [Validation(Required=false)]
        public string PublicKeyName { get; set; }

        /// <summary>
        /// <para>Specifies the region ID of the bastion host on which you want to create a public key for the user.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user for whom you want to create a public key.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/204522.html">ListUsers</a> operation to query the user ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
