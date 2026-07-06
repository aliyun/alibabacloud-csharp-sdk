// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListAgentStoragesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of agent storage information.</para>
        /// </summary>
        [NameInMap("AgentStorages")]
        [Validation(Required=false)]
        public List<ListAgentStoragesResponseBodyAgentStorages> AgentStorages { get; set; }
        public class ListAgentStoragesResponseBodyAgentStorages : TeaModel {
            /// <summary>
            /// <para>The description of the agent storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description for agent storage</para>
            /// </summary>
            [NameInMap("AgentStorageDescription")]
            [Validation(Required=false)]
            public string AgentStorageDescription { get; set; }

            /// <summary>
            /// <para>The name of the agent storage, which is a unique key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-test</para>
            /// </summary>
            [NameInMap("AgentStorageName")]
            [Validation(Required=false)]
            public string AgentStorageName { get; set; }

            /// <summary>
            /// <para>The specification of the agent storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSD</para>
            /// </summary>
            [NameInMap("AgentStorageSpecification")]
            [Validation(Required=false)]
            public string AgentStorageSpecification { get; set; }

            /// <summary>
            /// <para>The status of the agent storage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: Normal.</description></item>
            /// <item><description>forbidden: Disabled.</description></item>
            /// <item><description>deleting: Being released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("AgentStorageStatus")]
            [Validation(Required=false)]
            public string AgentStorageStatus { get; set; }

            /// <summary>
            /// <para>The alias of the agent storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btnots</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The time when the agent storage was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-16T06:02:59Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The region ID of the agent storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-cloudspe</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxh4em5jnbcd</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13542356466</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for querying subsequent pages. This parameter has a value only when not all tag resources are returned. If the total number of expected tag resources exceeds the MaxResults value, use this token to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESCG15aC1xxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39871ED2-62C0-578F-A32E-B88072D5582F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of agent storages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
