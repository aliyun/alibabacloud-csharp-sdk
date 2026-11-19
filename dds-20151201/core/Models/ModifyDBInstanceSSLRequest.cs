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
        /// <para>Specifies whether to force SSL encryption for connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: forces SSL encryption.</description></item>
        /// <item><description><b>0</b>: does not force SSL encryption.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Forced SSL encryption applies only to cloud disk instances running MongoDB 7.0 and 8.0, and the following minor engine version requirements must be met:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description>MongoDB 7.0: The minor engine version must be 8.0.13 or later.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>MongoDB 8.0: The minor engine version must be 9.0.5 or later.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: After forced SSL encryption is enabled, you cannot connect to the instance without SSL encryption.</warning></para>
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
        /// <para>Specifies the operation to perform on the SSL feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Open</b>: enables Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Close</b>: disables Secure Sockets Layer (SSL) encryption.</description></item>
        /// <item><description><b>Update</b>: updates the SSL certificate.</description></item>
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
        /// <para>Specifies the time when the SSL configuration of the MongoDB instance is modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: modifies the configuration immediately.</para>
        /// </description></item>
        /// <item><description><para>1: modifies the configuration within the maintenance window.</para>
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
