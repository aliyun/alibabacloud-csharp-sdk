// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultRequest : TeaModel {
        /// <summary>
        /// <para>Return additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ExtraImageControlList")]
        [Validation(Required=false)]
        public string ExtraImageControlList { get; set; }

        /// <summary>
        /// <para>Whether to return images.</para>
        /// <list type="bullet">
        /// <item><description>Y: Return</description></item>
        /// <item><description>N: Do not return</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("IsReturnImage")]
        [Validation(Required=false)]
        public string IsReturnImage { get; set; }

        /// <summary>
        /// <para>A unique business identifier defined by the merchant, used for subsequent troubleshooting. It supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure its uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djs20d***9-dsskc</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Whether to return anti-fraud detection results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("ReturnFiveCategorySpoofResult")]
        [Validation(Required=false)]
        public string ReturnFiveCategorySpoofResult { get; set; }

        /// <summary>
        /// <para>Authentication ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ab0b***cbde97</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
