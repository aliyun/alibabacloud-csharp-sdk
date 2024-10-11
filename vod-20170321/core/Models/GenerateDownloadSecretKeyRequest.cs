// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GenerateDownloadSecretKeyRequest : TeaModel {
        /// <summary>
        /// <para>A custom string of 16 to 32 characters in length. The string must contain uppercase letters, lowercase letters, and digits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppDecryptKeyAndroid20230101</para>
        /// </summary>
        [NameInMap("AppDecryptKey")]
        [Validation(Required=false)]
        public string AppDecryptKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the app.</para>
        /// <list type="bullet">
        /// <item><description>Android: the SHA-1 fingerprint of the keystore. The value is a string that contains a colon (:).</description></item>
        /// <item><description>iOS: the bundle ID of the app.</description></item>
        /// <item><description>Windows: the serial number in the digital signature certificate.</description></item>
        /// </list>
        /// <para>For more information about how to obtain the unique identifier of an app, see <a href="~~86107#section-wtj-9d7-lg2~~">Obtain the unique app identifier</a>.</para>
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
