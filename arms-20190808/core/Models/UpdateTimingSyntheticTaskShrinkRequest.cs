// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateTimingSyntheticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of assertions.</para>
        /// </summary>
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public string AvailableAssertionsShrink { get; set; }

        /// <summary>
        /// <para>The general settings.</para>
        /// </summary>
        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public string CommonSettingShrink { get; set; }

        /// <summary>
        /// <para>The custom cycle.</para>
        /// </summary>
        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public string CustomPeriodShrink { get; set; }

        /// <summary>
        /// <para>The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The monitoring configurations.</para>
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConfShrink { get; set; }

        /// <summary>
        /// <para>The list of monitoring points.</para>
        /// </summary>
        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public string MonitorsShrink { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloud DNS Task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the synthetic monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5308a2691f59422c8c3b7aeccxxxxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
