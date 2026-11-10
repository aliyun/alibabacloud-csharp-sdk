// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpdateDataMaskingEncryptionAlgorithmRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance-level column encryption algorithm. Select an available algorithm from ListDataMaskingEncryptionAlgorithms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256_GCM</para>
        /// </summary>
        [NameInMap("EncryptionAlgorithm")]
        [Validation(Required=false)]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// <para>The identifier of the Key Management Service (KMS) key. You can obtain it from Items[].KeyId in the response of ListKmsKeys. Provide this parameter when using a KMS key. Do not pass this parameter in local key scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The database instance identity. You can obtain it from Items[].InstanceId in the response of ListDataMaskingInstances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports ApsaraDB RDS, PolarDB, and PolarDB-X 2.0. If ProductId is also provided, the two parameters must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The identifier of the cloud service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: ApsaraDB RDS.</description></item>
        /// <item><description>8: PolarDB.</description></item>
        /// <item><description>27: PolarDB-X 2.0.
        /// If specified together with ProductCode, the values must match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

    }

}
