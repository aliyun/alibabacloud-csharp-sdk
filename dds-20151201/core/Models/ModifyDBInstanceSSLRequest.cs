// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp2235****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly enable SSL encryption for connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Forcibly enable SSL encryption.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not forcibly enable SSL encryption.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Forced SSL encryption is supported only for MongoDB 7.0 and 8.0 instances that use cloud disks and meet the following minor engine version requirements:</para>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>For version 7.0, the minor engine version must be 8.0.13 or later.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>For version 8.0, the minor engine version must be 9.0.5 or later.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>After you enable forced SSL encryption, only SSL connections to the instance are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

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
        /// <para>The operation to perform on the SSL feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Open</b>: Enable SSL encryption.</para>
        /// </description></item>
        /// <item><description><para><b>Close</b>: Disable SSL encryption.</para>
        /// </description></item>
        /// <item><description><para><b>Update</b>: Update the SSL certificate.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("SSLAction")]
        [Validation(Required=false)]
        public string SSLAction { get; set; }

        /// <summary>
        /// <para>The time to modify the SSL configuration of the MongoDB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Modify immediately.</para>
        /// </description></item>
        /// <item><description><para>1: Modify within the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
