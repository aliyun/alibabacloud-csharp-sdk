// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GenerateDownloadSecretKeyRequest : TeaModel {
        /// <summary>
        /// <para>The custom encryption private key string. The string must be 16 to 32 characters in length, consist of letters and digits, and contain uppercase letters, lowercase letters, and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppDecryptKeyAndroid20230101</para>
        /// </summary>
        [NameInMap("AppDecryptKey")]
        [Validation(Required=false)]
        public string AppDecryptKey { get; set; }

        /// <summary>
        /// <para>The unique app identifier.</para>
        /// <list type="bullet">
        /// <item><description>Android: the SHA-1 value of the keystore file. The obtained SHA-1 value must be a string that contains colons.</description></item>
        /// <item><description>iOS: the app bundle ID.</description></item>
        /// <item><description>Windows: the serial number of the digital signature certificate.</description></item>
        /// </list>
        /// <para>For more information about how to obtain the unique app identifier, see <a href="~~86107#section-wtj-9d7-lg2~~">Obtain the unique app identifier</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB:0D:AC:74:D3:21:09:EF:9C:71:1A:5E:77:2C:8E:BF:03:FD:FA:5A</para>
        /// </summary>
        [NameInMap("AppIdentification")]
        [Validation(Required=false)]
        public string AppIdentification { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
