// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataAgentApplication : TeaModel {
        /// <summary>
        /// <para>The ID of the currently associated Data Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avgwuxxxxxxxxhldt7el9</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The stable identifier of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac6izw6xxxxxxxxxxx3ulya0d</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app-name</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The access URL of the application. This URL is generated and returned as-is by RM when the deployment snapshot ready=true, and is not filtered again based on Status or ObservationStale. If not provided, this parameter is empty or omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://abc123.app.pre.datapaw-app.cloud">https://abc123.app.pre.datapaw-app.cloud</a></para>
        /// </summary>
        [NameInMap("AppUrl")]
        [Validation(Required=false)]
        public string AppUrl { get; set; }

        /// <summary>
        /// <para>The extended information of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ApplicationExtraInfo")]
        [Validation(Required=false)]
        public string ApplicationExtraInfo { get; set; }

        /// <summary>
        /// <para>The control revision number of the application. The initial value is 0. This number increments after a control request is accepted and can be passed as ExpectedRevision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ApplicationRevision")]
        [Validation(Required=false)]
        public long? ApplicationRevision { get; set; }

        /// <summary>
        /// <para>The error code for the current service unavailability, which is expressed separately from the error code of the most recent control request. If no error occurs, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCRIPT_EXIT_FAILED</para>
        /// </summary>
        [NameInMap("AvailabilityErrorCode")]
        [Validation(Required=false)]
        public string AvailabilityErrorCode { get; set; }

        /// <summary>
        /// <para>The summary of the cause for the current service unavailability. If no error occurs, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stage=script, exitCode=2</para>
        /// </summary>
        [NameInMap("AvailabilityErrorMessage")]
        [Validation(Required=false)]
        public string AvailabilityErrorMessage { get; set; }

        /// <summary>
        /// <para>The name of the application creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-name</para>
        /// </summary>
        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The UID of the application owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30031588888885853</para>
        /// </summary>
        [NameInMap("CreatorUid")]
        [Validation(Required=false)]
        public string CreatorUid { get; set; }

        /// <summary>
        /// <para>The description of the application, which can be up to 250 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the application was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-12T10:40:12.000+00:00</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the application was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-12T10:40:12.000+00:00</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The most recent user control request. If no control request has been made, this parameter is empty.</para>
        /// </summary>
        [NameInMap("LastRequest")]
        [Validation(Required=false)]
        public DataAgentApplicationLastRequest LastRequest { get; set; }
        public class DataAgentApplicationLastRequest : TeaModel {
            /// <summary>
            /// <para>The control action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEPLOY</description></item>
            /// <item><description>STOP</description></item>
            /// <item><description>RESTART</description></item>
            /// <item><description>DELETE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RESTART</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The error code for the failure of the most recent user control request. If no error occurs, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT_EXIT_FAILED</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The summary of the failure cause for the most recent user control request. If no error occurs, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stage=script, exitCode=2</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

        }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1673828888852166</para>
        /// </summary>
        [NameInMap("MainUid")]
        [Validation(Required=false)]
        public string MainUid { get; set; }

        /// <summary>
        /// <para>Specifies whether the runtime or service observation is missing or stale. If this parameter is set to true, the availability information may be outdated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ObservationStale")]
        [Validation(Required=false)]
        public bool? ObservationStale { get; set; }

        /// <summary>
        /// <para>Specifies whether the current platform service is available. This does not indicate whether the most recent control request succeeded or whether the business components are healthy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public bool? Ready { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the current or most recently associated session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axc3lsxxxxxxxxxdapwe</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The status of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>REGISTERED</description></item>
        /// <item><description>PREPARING</description></item>
        /// <item><description>WAITING_AGREEMENT: Indicates that the system is waiting for the owner of the target workspace to sign a valid agreement. The original deployment or restart request is still being executed. After the agreement is signed, RM automatically resumes the original request.</description></item>
        /// <item><description>SEALING</description></item>
        /// <item><description>REVIEWING</description></item>
        /// <item><description>DEPLOYING</description></item>
        /// <item><description>DEPLOYED</description></item>
        /// <item><description>DEPLOY_FAILED</description></item>
        /// <item><description>STOPPING</description></item>
        /// <item><description>STOPPED</description></item>
        /// <item><description>STOP_FAILED</description></item>
        /// <item><description>RECOVERING</description></item>
        /// <item><description>UNAVAILABLE</description></item>
        /// <item><description>DELETING</description></item>
        /// <item><description>DELETE_FAILED</description></item>
        /// <item><description>DELETED: The logical deletion terminal state. The application no longer appears in List or Describe operations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REGISTERED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch used for the actual deployment of the currently running application. If no resources are currently running, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-example</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC used for the actual deployment of the currently running application. If no resources are currently running, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-example</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3700inkdc2y7zs0r37m5pika6</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
