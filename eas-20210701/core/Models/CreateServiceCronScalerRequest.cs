// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceCronScalerRequest : TeaModel {
        /// <summary>
        /// 需要排除的时间点的cron表达式
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// 定时伸缩任务描述
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<CreateServiceCronScalerRequestScaleJobs> ScaleJobs { get; set; }
        public class CreateServiceCronScalerRequestScaleJobs : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 要执行伸缩任务的cron表达式
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// 执行伸缩任务的目标replica
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

        }

    }

}
