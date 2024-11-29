// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ImportJobsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateApp")]
        [Validation(Required=false)]
        public bool? AutoCreateApp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;kind&quot;: &quot;SchedulerXJobs&quot;,
        ///   &quot;type&quot;: &quot;JSON&quot;,
        ///   &quot;version&quot;: &quot;2.0&quot;,
        ///   &quot;content&quot;: [
        ///     {
        ///       &quot;appName&quot;: &quot;xxl-job-executor-perf-test-xx&quot;,
        ///       &quot;groupId&quot;: &quot;xxl-job-executor-perf-test-xx&quot;,
        ///       &quot;description&quot;: &quot;xxl-job-executor-xx&quot;,
        ///       &quot;jobConfigInfo&quot;: [
        ///         {
        ///           &quot;jobHandler&quot;: &quot;testJobVoidHandler&quot;,
        ///           &quot;dataOffset&quot;: 0,
        ///           &quot;executeMode&quot;: &quot;standalone&quot;,
        ///           &quot;monitorConfigInfo&quot;: {
        ///             &quot;alarmType&quot;: &quot;CustomContacts&quot;,
        ///             &quot;failLimitTimes&quot;: 1,
        ///             &quot;failEnable&quot;: true,
        ///             &quot;failRate&quot;: 100,
        ///             &quot;timeoutKillEnable&quot;: false,
        ///             &quot;missWorkerEnable&quot;: false,
        ///             &quot;sendChannel&quot;: &quot;webhook&quot;,
        ///             &quot;timeoutEnable&quot;: true,
        ///             &quot;timeout&quot;: 7200,
        ///             &quot;daysOfDeadline&quot;: 0,
        ///             &quot;successNotice&quot;: false
        ///           },
        ///           &quot;attemptInterval&quot;: 30,
        ///           &quot;cleanMode&quot;: &quot;{\&quot;cleanMode\&quot;:\&quot;NUM_ONLY\&quot;,\&quot;totalRemain\&quot;:300}&quot;,
        ///           &quot;description&quot;: &quot;&quot;,
        ///           &quot;routeStrategy&quot;: 1,
        ///           &quot;userName&quot;: &quot;xx&quot;,
        ///           &quot;userId&quot;: &quot;xx&quot;,
        ///           &quot;content&quot;: &quot;{\&quot;jobHandler\&quot;:\&quot;testJobVoidHandler\&quot;}&quot;,
        ///           &quot;maxConcurrency&quot;: 1,
        ///           &quot;maxAttempt&quot;: 0,
        ///           &quot;name&quot;: &quot;perf_auto_test_0&quot;,
        ///           &quot;xattrs&quot;: &quot;&quot;,
        ///           &quot;jobType&quot;: &quot;xxljob&quot;,
        ///           &quot;contentType&quot;: 1,
        ///           &quot;parameters&quot;: &quot;success-withMsg&quot;,
        ///           &quot;timeConfig&quot;: {
        ///             &quot;calendar&quot;: &quot;&quot;,
        ///             &quot;dataOffset&quot;: 0,
        ///             &quot;timeType&quot;: 1,
        ///             &quot;paramMap&quot;: {},
        ///             &quot;timeExpression&quot;: &quot;* * * * * ?&quot;
        ///           },
        ///           &quot;contactInfoList&quot;: [],
        ///           &quot;status&quot;: 0
        ///         }
        ///       ]
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

    }

}
