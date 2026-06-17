// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateCronJobPolicyServerlessResponseBody : TeaModel {
        /// <summary>
        /// <para>The action of the scheduled task. The value is fixed as <c>ModifyDBClusterServerlessConf</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyDBClusterServerlessConf</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The Cron expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 8 * * ?</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the task. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-07T04:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1fa3c0e7-b568-4f41-b703-463c96a91bd8</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the task. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>working</c>: The scheduled task is running.</para>
        /// </description></item>
        /// <item><description><para><c>finish</c>: The scheduled task is complete.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>working</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
