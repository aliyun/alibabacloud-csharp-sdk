// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class AddShortUrlRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the short URL, in days. The maximum value is 90.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("EffectiveDays")]
        [Validation(Required=false)]
        public string EffectiveDays { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the short URL. Maximum length: 13 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里短链测试</para>
        /// </summary>
        [NameInMap("ShortUrlName")]
        [Validation(Required=false)]
        public string ShortUrlName { get; set; }

        /// <summary>
        /// <para>The URL that you want to shorten. Maximum length: 1,000 characters.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Short Message Service does not currently support this API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.****.com/product/sms">https://www.****.com/product/sms</a></para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

    }

}
