// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeEncryptionDBSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region where the encryption key is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionDBRegion")]
        [Validation(Required=false)]
        public string EncryptionDBRegion { get; set; }

        /// <summary>
        /// <para>Indicates whether encryption is enabled. Valid values:</para>
        /// <para>Enabled: Encryption is enabled. Disabled: Encryption is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("EncryptionDBStatus")]
        [Validation(Required=false)]
        public string EncryptionDBStatus { get; set; }

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
        /// <item><description><para><b>Enabled</b></para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>944CED46-A6F7-40C6-B6DC-C6E5CC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
