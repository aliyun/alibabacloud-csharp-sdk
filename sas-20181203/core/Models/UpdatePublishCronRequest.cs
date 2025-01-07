// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishCronRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression that is used to specify the start time of the upgrade.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 5 10 * * ?</para>
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// <para>The day of a week on which you want to perform the upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MON</b></description></item>
        /// <item><description><b>TUE</b></description></item>
        /// <item><description><b>WED</b></description></item>
        /// <item><description><b>THU</b></description></item>
        /// <item><description><b>FRI</b></description></item>
        /// <item><description><b>SAT</b></description></item>
        /// <item><description><b>SUN</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUN</para>
        /// </summary>
        [NameInMap("CronDay")]
        [Validation(Required=false)]
        public string CronDay { get; set; }

        /// <summary>
        /// <para>The start timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657407600000</para>
        /// </summary>
        [NameInMap("CronTime")]
        [Validation(Required=false)]
        public long? CronTime { get; set; }

        /// <summary>
        /// <para>The type of the upgrade cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: every day</description></item>
        /// <item><description><b>week</b>: every week</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// <para>The duration of the upgrade. Unit: hours.</para>
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
