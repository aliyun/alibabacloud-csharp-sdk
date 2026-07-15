// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRayHistoryServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The display name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-ray-history-server</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The specifications of the public resource group. For a list of supported instance types, see <a href="https://help.aliyun.com/document_detail/171758.html">PAI-DLC billing</a>.&gt;Notice: Pricing varies based on the specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The time when the job was created. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the job is complete. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The time when the job was last modified. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:00Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The maximum running time. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxRuntimeMinutes")]
        [Validation(Required=false)]
        public int? MaxRuntimeMinutes { get; set; }

        /// <summary>
        /// <para>The ID of the Ray history server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rhsxxx</para>
        /// </summary>
        [NameInMap("RayHistoryServerId")]
        [Validation(Required=false)]
        public string RayHistoryServerId { get; set; }

        /// <summary>
        /// <para>The URL of the Ray dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://rhsxxx-dashboard.dsw-gateway-cn-wulanchabu.data.aliyun.com/">https://rhsxxx-dashboard.dsw-gateway-cn-wulanchabu.data.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("RayHistoryServerUrl")]
        [Validation(Required=false)]
        public string RayHistoryServerUrl { get; set; }

        /// <summary>
        /// <para>The code of the job status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotFound</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The message that describes the job status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the job belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the resource on which the job runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-resource-name</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The status of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage path of Ray logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket-test-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/tmp</para>
        /// </summary>
        [NameInMap("StoragePath")]
        [Validation(Required=false)]
        public string StoragePath { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10**************14</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who creates the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username of the user who creates the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myusername</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the job belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46099</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
