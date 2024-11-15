// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeShoppingReceiptRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://duguang-database-public.oss-cn-hangzhou.aliyuncs.com/multi_receipt_shopping_receipt/shop_receipt__ticket_2020-05-14-11-59-30.540668_01_List.jpg">http://duguang-database-public.oss-cn-hangzhou.aliyuncs.com/multi_receipt_shopping_receipt/shop_receipt__ticket_2020-05-14-11-59-30.540668_01_List.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
