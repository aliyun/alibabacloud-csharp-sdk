// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateMacRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm that is used to generate the message authentication code. Valid values vary based on the key specification:  </para>
        /// <list type="bullet">
        /// <item><description><para>HMAC_SM3</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_224</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_256</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_384</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_512</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HMAC_SHA_256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description>true: enabled</description></item>
        /// <item><description>false (default): disabled</description></item>
        /// </list>
        /// <para>DryRun mode is used to test API calls and verify whether you have the required permissions on the corresponding resources and whether the request parameters are correctly configured. When DryRun mode is enabled, KMS always returns a failure and provides the failure reason. Failure reasons include:</para>
        /// <list type="bullet">
        /// <item><description>DryRunOperationError: The request would succeed without the DryRun parameter.</description></item>
        /// <item><description>ValidationError: The parameters specified in the request are invalid.</description></item>
        /// <item><description>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the key. You can also specify a key alias or a key Amazon Resource Name (ARN). For more information about aliases, refer to <a href="https://help.aliyun.com/document_detail/480655.html">Manage key aliases</a>.</para>
        /// <remarks>
        /// <para>When you access a key that belongs to a different Alibaba Cloud account, you must specify the key ARN. The format of a key ARN is <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz630494463ejqjx****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The data for which you want to generate a message authentication code.  </para>
        /// <para>The value is Base64-encoded. For example, if the hexadecimal data is <c>[0x31, 0x32, 0x33, 0x34]</c>, the corresponding Base64-encoded value is <c>MTIzNA==</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
