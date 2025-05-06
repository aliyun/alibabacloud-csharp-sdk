// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateProcessDefinitionWithScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The code that is returned by the backend server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1400009</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateProcessDefinitionWithScheduleResponseBodyData Data { get; set; }
        public class UpdateProcessDefinitionWithScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The email address to receive alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:foo_bar@spark.alert.invalid.com">foo_bar@spark.alert.invalid.com</a></para>
            /// </summary>
            [NameInMap("alertEmailAddress")]
            [Validation(Required=false)]
            public string AlertEmailAddress { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_ack_one_cluster</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12***********</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-05T02:03:19Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The CRON expression that is used for scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("crontab")]
            [Validation(Required=false)]
            public string Crontab { get; set; }

            /// <summary>
            /// <para>The node description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The end of the end time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710432000000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The execution policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SERIAL</para>
            /// </summary>
            [NameInMap("executionType")]
            [Validation(Required=false)]
            public string ExecutionType { get; set; }

            /// <summary>
            /// <para>The serial number of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123223</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_batch_workflow</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the project to which the workflow belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-********</para>
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The status of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("releaseState")]
            [Validation(Required=false)]
            public string ReleaseState { get; set; }

            /// <summary>
            /// <para>The start time of the scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezoneId")]
            [Validation(Required=false)]
            public string TimezoneId { get; set; }

            /// <summary>
            /// <para>The time when the workflow was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05T06:24:27Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user that is used to initiate a scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113*********</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the user that is used to initiate a scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-********</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The hash code of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwerf*********</para>
            /// </summary>
            [NameInMap("versionHashCode")]
            [Validation(Required=false)]
            public string VersionHashCode { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public string Failed { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the returned code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No permission for resource action</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
