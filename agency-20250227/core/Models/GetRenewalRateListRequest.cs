// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetRenewalRateListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025Q4</para>
        /// </summary>
        [NameInMap("FiscalYearAndQuarter")]
        [Validation(Required=false)]
        public string FiscalYearAndQuarter { get; set; }

    }

}
