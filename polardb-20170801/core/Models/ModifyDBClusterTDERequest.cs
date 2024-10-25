// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterTDERequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the TDE key of the cluster to be automatically rotated within the next maintenance window after a lapse of the rotation period when a change in the KMS key version is detected. This parameter is supported only for custom keys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only for a PolarDB for PostgreSQL or PolarDB for PostgreSQL (Compatible with Oracle) cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public string EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic encryption for new tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only for a PolarDB for MySQL cluster.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role. A RAM role is a virtual identity that you can create within your Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/93689.html">RAM role overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926*****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Modifies the TDE status. Set the value to <b>Enable</b>.</para>
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
