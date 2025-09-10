// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceCronScalerRequest : TeaModel {
        /// <summary>
        /// <para>The points in time that are excluded when you schedule a CronHPA job. The points in time must be specified by using a cron expression.</para>
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// <para>The description of the CronHPA job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<CreateServiceCronScalerRequestScaleJobs> ScaleJobs { get; set; }
        public class CreateServiceCronScalerRequestScaleJobs : TeaModel {
            /// <summary>
            /// <para>The name of the CronHPA job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scale-job-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cron expression that is used to configure the execution time of the CronHPA job. For more information about how to configure cron expressions, see <b>Description of special characters</b> in this topic.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 18 * * * *</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>The number of instances that you want to configure for the CronHPA job.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
