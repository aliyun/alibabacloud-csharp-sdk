// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ExtraImageControlList")]
        [Validation(Required=false)]
        public string ExtraImageControlList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("IsReturnImage")]
        [Validation(Required=false)]
        public string IsReturnImage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>djs20d***9-dsskc</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("ReturnFiveCategorySpoofResult")]
        [Validation(Required=false)]
        public string ReturnFiveCategorySpoofResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4ab0b***cbde97</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
