// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCommissionableProductsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;oceanbase_obpre_public_intl,savingplan_common_public_intl&quot;</para>
        /// </summary>
        [NameInMap("CommodityCodeList")]
        [Validation(Required=false)]
        public string CommodityCodeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“FY26”</para>
        /// </summary>
        [NameInMap("FiscalYear")]
        [Validation(Required=false)]
        public string FiscalYear { get; set; }

        [NameInMap("ListShowStatusList")]
        [Validation(Required=false)]
        public List<string> ListShowStatusList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;oceanbase&quot;</para>
        /// </summary>
        [NameInMap("PipCodeList")]
        [Validation(Required=false)]
        public string PipCodeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“202509”</para>
        /// </summary>
        [NameInMap("RealEndMonth")]
        [Validation(Required=false)]
        public string RealEndMonth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>“202502”</para>
        /// </summary>
        [NameInMap("RealStartMonth")]
        [Validation(Required=false)]
        public string RealStartMonth { get; set; }

    }

}
