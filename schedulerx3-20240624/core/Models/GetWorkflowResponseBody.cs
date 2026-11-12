// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetWorkflowResponseBody : TeaModel {
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
        /// <para>The basic information of the workflow.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowResponseBodyData Data { get; set; }
        public class GetWorkflowResponseBodyData : TeaModel {
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
            /// <para>The custom calendar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workday</para>
            /// </summary>
            [NameInMap("Calendar")]
            [Validation(Required=false)]
            public string Calendar { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18582193685027xx</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The workflow description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my first workflow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The workflow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myWorkflow</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The workflow status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time expression. Set the time expression based on the selected time type.</para>
            /// <list type="bullet">
            /// <item><description><b>none</b>: Not required.</description></item>
            /// <item><description><b>cron</b>: Enter a standard cron expression. Online verification is supported.</description></item>
            /// <item><description><b>api</b>: Not required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 12 * * ?</para>
            /// </summary>
            [NameInMap("TimeExpression")]
            [Validation(Required=false)]
            public string TimeExpression { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: none</description></item>
            /// <item><description>1: cron</description></item>
            /// <item><description>100: api</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TimeType")]
            [Validation(Required=false)]
            public int? TimeType { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// <remarks>
            /// <para>By default, the time zone of the server in the current region is used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GMT+8</para>
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The updater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18582193685027xx</para>
            /// </summary>
            [NameInMap("Updater")]
            [Validation(Required=false)]
            public string Updater { get; set; }

            /// <summary>
            /// <para>The workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WorkflowId")]
            [Validation(Required=false)]
            public long? WorkflowId { get; set; }

            /// <summary>
            /// <para>The extended attributes.</para>
            /// <remarks>
            /// <para>Not supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Xattrs")]
            [Validation(Required=false)]
            public string Xattrs { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. This ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27B1345D-5F71-5972-8E4C-AABA6C6232F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
