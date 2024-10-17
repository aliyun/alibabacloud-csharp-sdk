// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCronClearConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Data configuration.</para>
        /// </summary>
        [NameInMap("DataCronClearConfig")]
        [Validation(Required=false)]
        public GetDataCronClearConfigResponseBodyDataCronClearConfig DataCronClearConfig { get; set; }
        public class GetDataCronClearConfigResponseBodyDataCronClearConfig : TeaModel {
            /// <summary>
            /// <para>The number of times that the task is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CronCallTimes")]
            [Validation(Required=false)]
            public string CronCallTimes { get; set; }

            /// <summary>
            /// <para>The crontab expression that you can use to run the task at a specified time. For more information, see <a href="https://help.aliyun.com/document_detail/206581.html">Crontab expression</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 23 ? * 7,1</para>
            /// </summary>
            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            /// <summary>
            /// <para>The time when the task was last run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-18 00:00:00</para>
            /// </summary>
            [NameInMap("CronLastCallStartTime")]
            [Validation(Required=false)]
            public string CronLastCallStartTime { get; set; }

            /// <summary>
            /// <para>The time when the task is run next time. This parameter is displayed only when the status of the scheduled task is SUCCESS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-19 00:00:00</para>
            /// </summary>
            [NameInMap("CronNextCallTime")]
            [Validation(Required=false)]
            public string CronNextCallTime { get; set; }

            /// <summary>
            /// <para>The status of the scheduled task. If this parameter is empty, it indicates the task is not run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PAUSE: The task is suspended.</description></item>
            /// <item><description>WAITING: The task is waiting to be run.</description></item>
            /// <item><description>SUCCESS: The task is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAUSE</para>
            /// </summary>
            [NameInMap("CronStatus")]
            [Validation(Required=false)]
            public string CronStatus { get; set; }

            /// <summary>
            /// <para>The number of times that the Optimize Table statement is automatically exeuted. This parameter is valid only when the value of the OptimizeTableAfterEveryClearTimes parameter is greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CurrentClearTaskCount")]
            [Validation(Required=false)]
            public long? CurrentClearTaskCount { get; set; }

            /// <summary>
            /// <para>The execution duration of the task. Unit: hours. If the value is 0, it indicates the duration is not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic execution of the OPTIMIZE TABLE statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disables automatic execution</description></item>
            /// <item><description>A number greater than 0: enables automatic execution. The number specifies the number of times that cleanup operations must be performed before the OPTIMIZE TABLE statement is automatically executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OptimizeTableAfterEveryClearTimes")]
            [Validation(Required=false)]
            public long? OptimizeTableAfterEveryClearTimes { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283C461F-11D8-48AA-B695-DF092DA32AF3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
