// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class CarbonEmissionElecSummaryItem : TeaModel {
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        [NameInMap("dataUnit")]
        [Validation(Required=false)]
        public string DataUnit { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ratio")]
        [Validation(Required=false)]
        public double? Ratio { get; set; }

        [NameInMap("rawData")]
        [Validation(Required=false)]
        public double? RawData { get; set; }

    }

}
