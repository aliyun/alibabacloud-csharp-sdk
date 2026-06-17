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
        /// <item><description><para><b>Enabled</b>: Automatic key rotation is allowed.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Automatic key rotation is not allowed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the database engine is compatible with PostgreSQL or Oracle syntax.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The unique ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic encryption is enabled for all newly created tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: Automatic encryption is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: Automatic encryption is disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the database engine is compatible with MySQL.</para>
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

        /// <summary>
        /// <para>The status of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: The key is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: The key is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E37D1508-EC3B-4E06-A24A-C7AC31******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The automatic key rotation interval configured in KMS. If no automatic key rotation interval is set, 0 s is returned. Unit: s.</para>
        /// <para>For example, if the rotation interval is 7 days, 604800 s is returned.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the database engine is compatible with PostgreSQL or Oracle syntax, and the value of <c>AutomaticRotation</c> is <c>Enabled</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>604800s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The region where the TDE key is located.</para>
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
        /// <item><description><para><b>Enabled</b>: TDE encryption is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: TDE encryption is disabled.</para>
        /// </description></item>
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
