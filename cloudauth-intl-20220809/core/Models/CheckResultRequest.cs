// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The additional information to return.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ExtraImageControlList")]
        [Validation(Required=false)]
        public string ExtraImageControlList { get; set; }

        /// <summary>
        /// <para>Specifies whether to return images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Returns images.</description></item>
        /// <item><description>N: Does not return images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("IsReturnImage")]
        [Validation(Required=false)]
        public string IsReturnImage { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. It supports a combination of letters and digits, with a maximum length of 32 characters. Make sure that the identifier is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djs20d***9-dsskc</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the anti-spoofing detection results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("ReturnFiveCategorySpoofResult")]
        [Validation(Required=false)]
        public string ReturnFiveCategorySpoofResult { get; set; }

        /// <summary>
        /// <para>The authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ab0b***cbde97</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
