// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishCronRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression for the upgrade start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 5 10 * * ?</para>
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <para>The day of the week for the upgrade time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MON</b>: Monday.</description></item>
        /// <item><description><b>TUE</b>: Tuesday.</description></item>
        /// <item><description><b>WED</b>: Wednesday.</description></item>
        /// <item><description><b>THU</b>: Thursday.</description></item>
        /// <item><description><b>FRI</b>: Friday.</description></item>
        /// <item><description><b>SAT</b>: Saturday.</description></item>
        /// <item><description><b>SUN</b>: Sunday.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUN</para>
        /// </summary>
        [NameInMap("CronDay")]
        [Validation(Required=false)]
        public string CronDay { get; set; }

        /// <summary>
        /// <para>The start timestamp of the release, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657407600000</para>
        /// </summary>
        [NameInMap("CronTime")]
        [Validation(Required=false)]
        public long? CronTime { get; set; }

        /// <summary>
        /// <para>The cycle type for the upgrade start time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: Daily.</description></item>
        /// <item><description><b>week</b>: Weekly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// <para>The duration of the upgrade, in hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

    }

}
