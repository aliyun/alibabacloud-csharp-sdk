// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class OperateFinanceTaxRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FinanceTax")]
        [Validation(Required=false)]
        public string FinanceTax { get; set; }

        [NameInMap("FinanceTaxCertificateImgName")]
        [Validation(Required=false)]
        public string FinanceTaxCertificateImgName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HId")]
        [Validation(Required=false)]
        public long? HId { get; set; }

        [NameInMap("SecondFinanceTax")]
        [Validation(Required=false)]
        public string SecondFinanceTax { get; set; }

        [NameInMap("SecondFinanceTaxCertificateImgName")]
        [Validation(Required=false)]
        public string SecondFinanceTaxCertificateImgName { get; set; }

        [NameInMap("SecondFinanceTaxCertificateImgUrl")]
        [Validation(Required=false)]
        public string SecondFinanceTaxCertificateImgUrl { get; set; }

        [NameInMap("financeTaxCertificateImgUrl")]
        [Validation(Required=false)]
        public string FinanceTaxCertificateImgUrl { get; set; }

    }

}
