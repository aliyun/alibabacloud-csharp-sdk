// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetCarbonEmissionTrendRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Module code.
        /// </summary>
        [NameInMap("moduleCode")]
        [Validation(Required=false)]
        public string ModuleCode { get; set; }

        /// <summary>
        /// Module type.
        /// </summary>
        [NameInMap("moduleType")]
        [Validation(Required=false)]
        public int? ModuleType { get; set; }

        /// <summary>
        /// Trend Type.
        /// </summary>
        [NameInMap("trendType")]
        [Validation(Required=false)]
        public int? TrendType { get; set; }

        /// <summary>
        /// The list of inventory year.
        /// </summary>
        [NameInMap("yearList")]
        [Validation(Required=false)]
        public List<int?> YearList { get; set; }

    }

}
