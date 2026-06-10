// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClusterAgentInstallRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>B149FD9C-ED5C-5765-B3AD-05AA4A4D64D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates authorization succeeded;  </description></item>
        /// <item><description>Other status codes indicate authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error message;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListClusterAgentInstallRecordsResponseBodyData> Data { get; set; }
        public class ListClusterAgentInstallRecordsResponseBodyData : TeaModel {
            [NameInMap("agent_config_id")]
            [Validation(Required=false)]
            public string AgentConfigId { get; set; }

            [NameInMap("agent_config_name")]
            [Validation(Required=false)]
            public string AgentConfigName { get; set; }

            /// <summary>
            /// <para>Cluster ID.  </para>
            /// <remarks>
            /// <para>This cluster ID is not the ACK cluster ID</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cbf7a37bc905d4682a3338b3744810269</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-25T15:08:19</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Canary release environment</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("grayscale_config")]
            [Validation(Required=false)]
            public string GrayscaleConfig { get; set; }

            /// <summary>
            /// <para>Widget ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
            /// </summary>
            [NameInMap("plugin_id")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>Plugin version</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.4.0-1</para>
            /// </summary>
            [NameInMap("plugin_version")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-25T15:08:19</para>
            /// </summary>
            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
