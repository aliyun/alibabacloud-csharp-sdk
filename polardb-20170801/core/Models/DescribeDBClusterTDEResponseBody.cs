// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterTDEResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic key rotation is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.<remarks>
        /// <para>This parameter is returned only when the database engine is PostgreSQL-compatible or Oracle-syntax-compatible.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic encryption of all newly created tables is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Disabled.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the database engine is MySQL-compatible.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("EncryptNewTables")]
        [Validation(Required=false)]
        public string EncryptNewTables { get; set; }

        /// <summary>
        /// <para>The custom key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a4f4ac2-<b><b>-</b></b>-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The status of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E37D1508-EC3B-4E06-A24A-C7AC31******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The automatic key rotation interval configured in Key Management Service (KMS). If no automatic key rotation interval is configured, 0 s is returned. Unit: s.</para>
        /// <para>For example, if the rotation interval is 7 days, 604800 s is returned.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the database engine is PostgreSQL-compatible or Oracle-syntax-compatible and the value of AutomaticRotation is Enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>604800s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The region where the TDE key resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TDERegion")]
        [Validation(Required=false)]
        public string TDERegion { get; set; }

        /// <summary>
        /// <para>Indicates whether TDE is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
