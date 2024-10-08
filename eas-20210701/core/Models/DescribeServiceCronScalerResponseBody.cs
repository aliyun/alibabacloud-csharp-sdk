// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceCronScalerResponseBody : TeaModel {
        /// <summary>
        /// <para>The points in time that are excluded when you schedule a CronHPA job. The points in time must be specified by using a cron expression.</para>
        /// </summary>
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The CronHPA jobs.</para>
        /// </summary>
        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<DescribeServiceCronScalerResponseBodyScaleJobs> ScaleJobs { get; set; }
        public class DescribeServiceCronScalerResponseBodyScaleJobs : TeaModel {
            /// <summary>
            /// <para>The time when the most recent CronHPA job was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-24T02:11:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the most recent CronHPA job ran. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-24T06:31:00Z</para>
            /// </summary>
            [NameInMap("LastProbeTime")]
            [Validation(Required=false)]
            public string LastProbeTime { get; set; }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;cron hpa job scale-jobs-0 executed successfully. current replicas:3, desired replicas:2.&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

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
            /// <para>The cron expression that is used to configure the execution time of the CronHPA job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 18 * * * *</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>The status of the most recent CronHPA job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of instances that you expect to configure for the CronHPA job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

        }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
