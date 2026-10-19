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
        /// <para>Specifies whether to force Secure Sockets Layer (SSL) encryption for connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Forces Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>0</b>: Does not force Secure Sockets Layer (SSL) encryption.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Forced Secure Sockets Layer (SSL) encryption applies only to MongoDB 7.0 and 8.0 instances that use cloud disks and meet the following minor engine version requirements:<list type="bullet">
        /// <item><description>MongoDB 7.0: The minor engine version must be 8.0.13 or later.</description></item>
        /// <item><description>MongoDB 8.0: The minor engine version must be 9.0.5 or later.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: After you enable forced Secure Sockets Layer (SSL) encryption, you cannot connect to the instance by using non-SSL connections.</warning></para>
        /// </remarks>
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
        /// <item><description><b>Open</b>: Enables Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Close</b>: Disables Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Update</b>: Updates the SSL certificate.</description></item>
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
        /// <para>The time when the SSL configuration of the MongoDB instance is modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Modifies the configuration immediately.</para>
        /// </description></item>
        /// <item><description><para>1: Modifies the configuration within the O&amp;M window.</para>
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
