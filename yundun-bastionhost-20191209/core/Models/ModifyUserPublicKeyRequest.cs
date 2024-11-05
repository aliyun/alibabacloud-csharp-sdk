// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyUserPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the user group. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host on which you want to modify the public key of a user.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-nif236pmc1u</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new public key.</para>
        /// <remarks>
        /// <para> Specify a Base64-encoded string.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c3NoLWVkMjU1MTkgQUFBQUMzTnphQzFsWkRJMU5URTVBQUFBSUhVcjY4UENFYWFzZjFYRVpNYTVsMlNBQytHV3FpeXVsRVpndkV4dmlPM28gcm9vdEA5NjBkMmNhOTcwYjU=</para>
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// <para>The ID of the public key that you want to modify.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/477555.html">ListUserPublicKeys</a> operation to query the public key ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PublicKeyId")]
        [Validation(Required=false)]
        public string PublicKeyId { get; set; }

        /// <summary>
        /// <para>The name of the public key that you want to modify. This name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("PublicKeyName")]
        [Validation(Required=false)]
        public string PublicKeyName { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host that is used to modify the public key of the user.</para>
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

    }

}
