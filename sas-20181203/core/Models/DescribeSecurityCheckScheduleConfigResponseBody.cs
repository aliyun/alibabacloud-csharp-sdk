// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityCheckScheduleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48D2E9A9-A1B0-4295-B727-0995757C47E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of custom check tasks.</para>
        /// </summary>
        [NameInMap("RiskCheckJobConfig")]
        [Validation(Required=false)]
        public DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig RiskCheckJobConfig { get; set; }
        public class DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig : TeaModel {
            /// <summary>
            /// <para>The day of the week when the check tasks are performed. Multiple days can be specified. Multiple days are separated by commas (,).</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Monday</description></item>
            /// <item><description><b>2</b>: Tuesday</description></item>
            /// <item><description><b>3</b>: Wednesday</description></item>
            /// <item><description><b>4</b>: Thursday</description></item>
            /// <item><description><b>5</b>: Friday</description></item>
            /// <item><description><b>6</b>: Saturday</description></item>
            /// <item><description><b>7</b>: Sunday</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("DaysOfWeek")]
            [Validation(Required=false)]
            public string DaysOfWeek { get; set; }

            /// <summary>
            /// <para>The time range during which check tasks end. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>6</b>: 00:00 to 06:00</description></item>
            /// <item><description><b>12</b>: 06:00 to 12:00</description></item>
            /// <item><description><b>18</b>: 12:00 to 18:00</description></item>
            /// <item><description><b>24</b>: 18:00 to 24:00</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The time range during which check tasks start. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: 00:00 to 06:00</description></item>
            /// <item><description><b>6</b>: 06:00 to 12:00</description></item>
            /// <item><description><b>12</b>: 12:00 to 18:00</description></item>
            /// <item><description><b>18</b>: 18:00 to 24:00</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

    }

}
