// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetElecTrendRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// List of years.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("yearList")]
        [Validation(Required=false)]
        public List<int?> YearList { get; set; }

    }

}
