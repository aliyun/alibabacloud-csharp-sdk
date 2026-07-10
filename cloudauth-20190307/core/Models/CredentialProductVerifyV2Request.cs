// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialProductVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>The credential name. Only the following value is supported: 0501 (product image).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0501</para>
        /// </summary>
        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        /// <summary>
        /// <para>The credential type. Only the following value is supported: 05 (product image).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>The InputStream object of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyundoc.com/picture*****.jpeg">https://aliyundoc.com/picture*****.jpeg</a></para>
        /// </summary>
        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyundoc.com/picture*****.jpeg">https://aliyundoc.com/picture*****.jpeg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The merchant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无。</para>
        /// </summary>
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>The call mode. Only the following value is supported: ANTI_FAKE_CHECK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
