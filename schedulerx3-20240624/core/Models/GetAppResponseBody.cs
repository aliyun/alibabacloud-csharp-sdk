// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The details of the application.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAppResponseBodyData Data { get; set; }
        public class GetAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The access token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2f4ddeab8e344ed68e0402cf9b8502ffv3</para>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <para>The creator of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18582193685027xx</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Indicates whether logging is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableLog")]
            [Validation(Required=false)]
            public bool? EnableLog { get; set; }

            /// <summary>
            /// <para>The number of executors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExecutorNum")]
            [Validation(Required=false)]
            public long? ExecutorNum { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3402</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("JobNum")]
            [Validation(Required=false)]
            public int? JobNum { get; set; }

            [NameInMap("LabelRouteStrategy")]
            [Validation(Required=false)]
            public int? LabelRouteStrategy { get; set; }

            /// <summary>
            /// <para>The leader address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://28.***.***.3:80">http://28.***.***.3:80</a></para>
            /// </summary>
            [NameInMap("Leader")]
            [Validation(Required=false)]
            public string Leader { get; set; }

            /// <summary>
            /// <para>The maximum concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxConcurrency")]
            [Validation(Required=false)]
            public int? MaxConcurrency { get; set; }

            /// <summary>
            /// <para>The maximum number of jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxJobs")]
            [Validation(Required=false)]
            public int? MaxJobs { get; set; }

            /// <summary>
            /// <para>The title of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试应用</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The last user to update the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18582193685027xx</para>
            /// </summary>
            [NameInMap("Updater")]
            [Validation(Required=false)]
            public string Updater { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not found: appName not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, generated by Alibaba Cloud. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0DE9C33-992A-580B-89C4-B609A292748D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
