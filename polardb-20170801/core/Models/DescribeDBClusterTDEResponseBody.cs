// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterTDEResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic key rotation is allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Automatic key rotation is allowed.</description></item>
        /// <item><description><b>Disabled</b>: Automatic key rotation is not allowed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only for a PolarDB for PostgreSQL or PolarDB for PostgreSQL (Compatible with Oracle) cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic encryption is enabled for new tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only for a PolarDB for MySQL cluster.</para>
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
        /// <para>2a4f4ac2-<b><b>-</b></b>-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E37D1508-EC3B-4E06-A24A-C7AC31******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The automatic key rotation period configured in Key Management Service (KMS). If no automatic key rotation period is configured, 0s is returned. Unit: seconds.</para>
        /// <para>For example, if the rotation period is set to 7 days, 604800s is returned.</para>
        /// <remarks>
        /// <para> This parameter is returned only for a PolarDB for PostgreSQL or PolarDB for PostgreSQL (Compatible with Oracle) cluster whose AutomaticRotation parameter is set to Enabled.</para>
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
        /// <para>Indicates whether TDE encryption is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
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
