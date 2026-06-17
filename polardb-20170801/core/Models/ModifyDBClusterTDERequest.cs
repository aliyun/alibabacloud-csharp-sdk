// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterTDERequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically rotate the TDE key of the instance during the next O\&amp;M window after a new version of the KMS key is available. This parameter is valid only for custom keys.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when the database engine is compatible with PostgreSQL or Oracle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public string EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically encrypt all new tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b></para>
        /// </description></item>
        /// <item><description><para><b>OFF</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when the database engine is compatible with MySQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EncryptNewTables")]
        [Validation(Required=false)]
        public string EncryptNewTables { get; set; }

        /// <summary>
        /// <para>The ID of the custom key.</para>
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
        /// <para>The Global Resource Descriptor of the role. You can use this parameter to specify a role. For more information, see <a href="https://help.aliyun.com/document_detail/93689.html">Overview of RAM roles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926*****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The TDE status. Set the value to <b>Enable</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
