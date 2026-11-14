// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAgentInstanceMemoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The memory configurations and statistics information of the agent instances on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgentInstanceMemoryResponseBodyData> Data { get; set; }
        public class ListAgentInstanceMemoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the agent instance, which can be used to configure the instance memory switch or clear the instance memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agi-08vm****</para>
            /// </summary>
            [NameInMap("AgentInstanceId")]
            [Validation(Required=false)]
            public string AgentInstanceId { get; set; }

            /// <summary>
            /// <para>The instance lifetime and epoch status of the agent instance.</para>
            /// <list type="bullet">
            /// <item><description><c>UNDEPLOYED</c>: No deployment.</description></item>
            /// <item><description><c>DEPLOYING</c>: Deployment in progress.</description></item>
            /// <item><description><c>DEPLOYED</c>: Deployment completed.</description></item>
            /// <item><description><c>STARTING</c>: Starting.</description></item>
            /// <item><description><c>RUNNING</c>: Running.</description></item>
            /// <item><description><c>STOPPING</c>: Stopping.</description></item>
            /// <item><description><c>STOPPED</c>: Stopped.</description></item>
            /// <item><description><c>UNAVAILABLE</c>: Not active.</description></item>
            /// <item><description><c>FAILED</c>: Failed.</description></item>
            /// <item><description><c>UPGRADING</c>: Upgrade in progress.</description></item>
            /// <item><description><c>REBUILDING</c>: Reset in progress.</description></item>
            /// <item><description><c>DELETING</c>: Deleting.</description></item>
            /// <item><description><c>DELETED</c>: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AgentInstanceStatus")]
            [Validation(Required=false)]
            public string AgentInstanceStatus { get; set; }

            /// <summary>
            /// <para>The business platform to which the agent belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
            /// </summary>
            [NameInMap("AgentPlatform")]
            [Validation(Required=false)]
            public string AgentPlatform { get; set; }

            /// <summary>
            /// <para>The provider of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AgenticComputer</para>
            /// </summary>
            [NameInMap("AgentProvider")]
            [Validation(Required=false)]
            public string AgentProvider { get; set; }

            /// <summary>
            /// <para>The number of undeleted memory backups for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupCount")]
            [Validation(Required=false)]
            public int? BackupCount { get; set; }

            /// <summary>
            /// <para>The ID of the end user to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time of the last memory update. The time is returned in the YYYY-MM-DDThh:mm:ss format, with optional fractional seconds. The time value uses the default time zone of the server, and the string does not include a time zone offset. This field is omitted if the last update time is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-26T21:14:36.693</para>
            /// </summary>
            [NameInMap("LastMemoryUpdatedAt")]
            [Validation(Required=false)]
            public string LastMemoryUpdatedAt { get; set; }

            /// <summary>
            /// <para>The time of the latest backup. The time is returned in the YYYY-MM-DDThh:mm:ss format, with optional fractional seconds. The time value uses the default time zone of the server, and the string does not include a time zone offset. This field is omitted if the backup time is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-26T20:58:00.536</para>
            /// </summary>
            [NameInMap("LatestBackupAt")]
            [Validation(Required=false)]
            public string LatestBackupAt { get; set; }

            /// <summary>
            /// <para>The number of memory entries for the instance. This field may be omitted if statistics are unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MemoryCount")]
            [Validation(Required=false)]
            public long? MemoryCount { get; set; }

            /// <summary>
            /// <para>The memory switch configured for the instance, returned as a string. A value of <c>true</c> indicates that the switch is turned on. A value of <c>false</c> indicates that the switch is turned off.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MemoryEnabled")]
            [Validation(Required=false)]
            public string MemoryEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the region where the runtime environment is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource associated with the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-d8ut****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The runtime ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-d8ut****</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>The name of the runtime environment. The name of the associated resource is returned first. If the resource name is unavailable, the instance name is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office Assistant</para>
            /// </summary>
            [NameInMap("RuntimeName")]
            [Validation(Required=false)]
            public string RuntimeName { get; set; }

            /// <summary>
            /// <para>The list of user groups to which the end user belongs.</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListAgentInstanceMemoryResponseBodyDataUserGroups> UserGroups { get; set; }
            public class ListAgentInstanceMemoryResponseBodyDataUserGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group-aliy****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Office user group</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The username of the end user to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The list of organizations to which the end user belongs.</para>
            /// </summary>
            [NameInMap("UserOrgs")]
            [Validation(Required=false)]
            public List<ListAgentInstanceMemoryResponseBodyDataUserOrgs> UserOrgs { get; set; }
            public class ListAgentInstanceMemoryResponseBodyDataUserOrgs : TeaModel {
                /// <summary>
                /// <para>The ID of the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org-aliy****</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The name of the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise office</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

            /// <summary>
            /// <para>The Wuying user ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c614d26****</para>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

        /// <summary>
        /// <para>The current page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page used for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1CEEB-CDFF-18F9-B2BF-9997600D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
