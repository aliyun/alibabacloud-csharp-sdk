// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckVerifyLogRequest : TeaModel {
        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. It supports a combination of letters and digits and can be up to 32 characters in length. Make sure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the entire authentication process. You must call the Initialize operation to obtain this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hksb7ba1b*********015d694361bee4</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
