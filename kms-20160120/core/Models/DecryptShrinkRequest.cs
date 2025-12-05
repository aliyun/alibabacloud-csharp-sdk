// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ciphertext that you want to decrypt.</para>
        /// <para>You can generate the ciphertext by calling the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DZhOWVmZDktM2QxNi00ODk0LWJkNGYtMWZjNDNmM2YyYWJmaaSl+TztSIMe43nbTH/Z1Wr4XfLftKhAciUmDQXuMRl4WTvKhxjMThjK****</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of key-value pairs.</para>
        /// <remarks>
        /// <para> If you specify the EncryptionContext parameter when you call the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>, <a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a>, or <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation, you must specify the same context when you call the Decrypt operation. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

    }

}
