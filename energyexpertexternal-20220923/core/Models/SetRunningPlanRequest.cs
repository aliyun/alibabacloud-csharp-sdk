// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SetRunningPlanRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("controlType")]
        [Validation(Required=false)]
        public int? ControlType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("dateType")]
        [Validation(Required=false)]
        public int? DateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05:00:00</para>
        /// </summary>
        [NameInMap("earliestStartupTime")]
        [Validation(Required=false)]
        public string EarliestStartupTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-21</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05:30:00</para>
        /// </summary>
        [NameInMap("latestShutdownTime")]
        [Validation(Required=false)]
        public string LatestShutdownTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.1</para>
        /// </summary>
        [NameInMap("maxCarbonDioxide")]
        [Validation(Required=false)]
        public double? MaxCarbonDioxide { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.1</para>
        /// </summary>
        [NameInMap("maxTem")]
        [Validation(Required=false)]
        public double? MaxTem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.1</para>
        /// </summary>
        [NameInMap("minTem")]
        [Validation(Required=false)]
        public double? MinTem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ib</para>
        /// </summary>
        [NameInMap("pKey")]
        [Validation(Required=false)]
        public string PKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("seasonMode")]
        [Validation(Required=false)]
        public int? SeasonMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-20</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-31</para>
        /// </summary>
        [NameInMap("statisticsTime")]
        [Validation(Required=false)]
        public string StatisticsTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system1</para>
        /// </summary>
        [NameInMap("systemId")]
        [Validation(Required=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05:30:00</para>
        /// </summary>
        [NameInMap("workingEndTime")]
        [Validation(Required=false)]
        public string WorkingEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05:00:00</para>
        /// </summary>
        [NameInMap("workingStartTime")]
        [Validation(Required=false)]
        public string WorkingStartTime { get; set; }

    }

}
