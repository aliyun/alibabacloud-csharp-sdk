// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetPublishCronResponseBody : TeaModel {
        /// <summary>
        /// <para>The publish scheduling configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPublishCronResponseBodyData Data { get; set; }
        public class GetPublishCronResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cron expression for the upgrade start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 7 * * ?</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The day of the week for the upgrade. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MON</b>: Monday</description></item>
            /// <item><description><b>TUE</b>: Tuesday</description></item>
            /// <item><description><b>WED</b>: Wednesday</description></item>
            /// <item><description><b>THU</b>: Thursday</description></item>
            /// <item><description><b>FRI</b>: Friday</description></item>
            /// <item><description><b>SAT</b>: Saturday</description></item>
            /// <item><description><b>SUN</b>: Sunday.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MON</para>
            /// </summary>
            [NameInMap("CronDay")]
            [Validation(Required=false)]
            public string CronDay { get; set; }

            /// <summary>
            /// <para>The publish start timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724522400000</para>
            /// </summary>
            [NameInMap("CronTime")]
            [Validation(Required=false)]
            public long? CronTime { get; set; }

            /// <summary>
            /// <para>The upgrade start cycle type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b>: every day</description></item>
            /// <item><description><b>week</b>: every week.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("CronType")]
            [Validation(Required=false)]
            public string CronType { get; set; }

            /// <summary>
            /// <para>The upgrade duration. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
