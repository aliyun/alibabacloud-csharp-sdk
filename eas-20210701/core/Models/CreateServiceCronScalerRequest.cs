// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceCronScalerRequest : TeaModel {
        /// <summary>
        /// The points in time that are excluded when you schedule a CronHPA job. The points in time must be specified by using a cron expression.
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// The description of the CronHPA job.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<CreateServiceCronScalerRequestScaleJobs> ScaleJobs { get; set; }
        public class CreateServiceCronScalerRequestScaleJobs : TeaModel {
            /// <summary>
            /// The name of the CronHPA job.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The cron expression that is used to configure the execution time of the CronHPA job. For more information about how to configure cron expressions, see **Description of special characters** in this topic.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// The number of instances that you want to configure for the CronHPA job.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

        }

    }

}
