// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialProductVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>Credential name: Only supports value 0501 (product image).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0501</para>
        /// </summary>
        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        /// <summary>
        /// <para>Credential type: Only supports value 05 (product image).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>InputStream object of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyundoc.com/picture*****.jpeg">https://aliyundoc.com/picture*****.jpeg</a></para>
        /// </summary>
        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// <para>URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyundoc.com/picture*****.jpeg">https://aliyundoc.com/picture*****.jpeg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Merchant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无。</para>
        /// </summary>
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>Invocation mode:
        /// Only supports value ANTI_FAKE_CHECK.</para>
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
