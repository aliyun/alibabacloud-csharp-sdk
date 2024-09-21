// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SetRunningPlanRequest : TeaModel {
        [NameInMap("controlType")]
        [Validation(Required=false)]
        public int? ControlType { get; set; }

        [NameInMap("dateType")]
        [Validation(Required=false)]
        public int? DateType { get; set; }

        [NameInMap("earliestStartupTime")]
        [Validation(Required=false)]
        public string EarliestStartupTime { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        [NameInMap("latestShutdownTime")]
        [Validation(Required=false)]
        public string LatestShutdownTime { get; set; }

        [NameInMap("maxCarbonDioxide")]
        [Validation(Required=false)]
        public double? MaxCarbonDioxide { get; set; }

        [NameInMap("maxTem")]
        [Validation(Required=false)]
        public double? MaxTem { get; set; }

        [NameInMap("minTem")]
        [Validation(Required=false)]
        public double? MinTem { get; set; }

        [NameInMap("pKey")]
        [Validation(Required=false)]
        public string PKey { get; set; }

        [NameInMap("seasonMode")]
        [Validation(Required=false)]
        public int? SeasonMode { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("statisticsTime")]
        [Validation(Required=false)]
        public string StatisticsTime { get; set; }

        [NameInMap("systemId")]
        [Validation(Required=false)]
        public string SystemId { get; set; }

        [NameInMap("workingEndTime")]
        [Validation(Required=false)]
        public string WorkingEndTime { get; set; }

        [NameInMap("workingStartTime")]
        [Validation(Required=false)]
        public string WorkingStartTime { get; set; }

    }

}
