// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateDataKeyWithoutPlaintextRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the DryRun mode.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the DryRun mode.</para>
        /// </description></item>
        /// </list>
        /// <para>The DryRun mode is used to test API calls, verify your permissions on the required resources, and check if the request parameters are valid. If you enable the DryRun mode, KMS returns a failure response with a reason. The failure reasons include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter was not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The request parameters are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>A JSON string of key-value pairs. If you specify this parameter, you must provide the same parameter when you call the Decrypt operation. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the CMK. You can also specify an alias that is bound to the CMK. For more information about how to use an alias, see Alias overview.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>599fa825-17de-417e-9554-bb032cc6****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The length of the data key to generate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AES_256: a 256-bit symmetric key</para>
        /// </description></item>
        /// <item><description><para>AES_128: a 128-bit symmetric key</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Use KeySpec or NumberOfBytes to specify the length of the data key. If you do not specify either parameter, KMS generates a 256-bit data key. If you specify both parameters, KMS ignores the KeySpec parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// <para>The length of the data key to generate.<br> Valid values: 1 to 1024.<br> Unit: bytes<br><br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

    }

}
