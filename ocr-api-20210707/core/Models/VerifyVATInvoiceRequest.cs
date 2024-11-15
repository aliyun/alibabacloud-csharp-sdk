// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class VerifyVATInvoiceRequest : TeaModel {
        [NameInMap("InvoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InvoiceDate")]
        [Validation(Required=false)]
        public string InvoiceDate { get; set; }

        [NameInMap("InvoiceKind")]
        [Validation(Required=false)]
        public int? InvoiceKind { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InvoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        [NameInMap("InvoiceSum")]
        [Validation(Required=false)]
        public string InvoiceSum { get; set; }

        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
