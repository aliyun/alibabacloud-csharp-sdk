// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyEncryptionDBSecretRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The status of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b></para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionDBStatus")]
        [Validation(Required=false)]
        public string EncryptionDBStatus { get; set; }

        /// <summary>
        /// <para>The key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b>*****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

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

        /// <summary>
        /// <para>The Global Resource Descriptor (GRD) of the role. For more information, see <a href="https://help.aliyun.com/document_detail/93689.html">Overview of RAM roles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926*****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
