// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceCronScalerRequest : TeaModel {
        /// <summary>
        /// <para>The cron expressions for the dates to exclude from the schedule.</para>
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// <para>The scheduled scaling tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<UpdateServiceCronScalerRequestScaleJobs> ScaleJobs { get; set; }
        public class UpdateServiceCronScalerRequestScaleJobs : TeaModel {
            /// <summary>
            /// <para>The name of the scheduled auto scaling task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scale-job-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cron expression that specifies when to run the scaling task. For more information about cron expressions, see the <b>Cron expressions</b> section in this topic.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 18 * * * *</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>The target number of instances for the scaling task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

            /// <summary>
            /// <para>The time zone for the cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
