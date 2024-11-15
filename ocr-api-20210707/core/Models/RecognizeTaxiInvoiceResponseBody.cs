// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeTaxiInvoiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	&quot;data&quot;: { 		&quot;licensePlateNumber&quot;: &quot;B-30T76&quot;, 		&quot;date&quot;: &quot;2018-09-28&quot;, 		&quot;invoiceCode&quot;: &quot;150001583910&quot;, 		&quot;invoiceNumber&quot;: &quot;22566685&quot;, 		&quot;mileage&quot;: &quot;22.8&quot;, 		&quot;fare&quot;: &quot;¥57.00&quot;, 		&quot;dropOffTime&quot;: &quot;01：40&quot;, 		&quot;pickUpTime&quot;: &quot;01：19&quot; 	}, 	&quot;ftype&quot;: 0, 	&quot;height&quot;: 982, 	&quot;orgHeight&quot;: 982, 	&quot;orgWidth&quot;: 364,  	&quot;width&quot;: 364 }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
