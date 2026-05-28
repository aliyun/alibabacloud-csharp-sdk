// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// <para>The settings of the service log feature.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<LoggingLoggingDetails> LoggingDetails { get; set; }
        public class LoggingLoggingDetails : TeaModel {
            /// <summary>
            /// <para>The logstore name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The type of the service logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>consumergroup_log: the consumption delay logs of consumer groups.</description></item>
            /// <item><description>logtail_alarm: the alert logs of Logtail.</description></item>
            /// <item><description>operation_log: the operation logs. You are charged for operation logs.</description></item>
            /// <item><description>logtail_profile: the collection logs of Logtail.</description></item>
            /// <item><description>metering: the metering logs.</description></item>
            /// <item><description>logtail_status: the status logs of Logtail.</description></item>
            /// <item><description>scheduledsqlalert: the operational logs of scheduled SQL jobs.</description></item>
            /// <item><description>etl_alert: the operational logs of data transformation jobs.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumergroup_log</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the project to which service logs are stored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
