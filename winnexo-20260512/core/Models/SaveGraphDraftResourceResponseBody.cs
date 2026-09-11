// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveGraphDraftResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>草稿变更 ID；内容与在线完全一致被跳过时为 null</para>
        /// 
        /// <b>Example:</b>
        /// <para>401001</para>
        /// </summary>
        [NameInMap("draftChangeId")]
        [Validation(Required=false)]
        public long? DraftChangeId { get; set; }

        /// <summary>
        /// <para>草稿内容哈希；被跳过时为 null</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:abc123</para>
        /// </summary>
        [NameInMap("draftContentHash")]
        [Validation(Required=false)]
        public string DraftContentHash { get; set; }

        /// <summary>
        /// <para>资源小类：resourceType=object 时固定 object_type；resourceType=element 时为 indicator / logic / process / rule / analysis 之一</para>
        /// 
        /// <b>Example:</b>
        /// <para>object_type</para>
        /// </summary>
        [NameInMap("elementType")]
        [Validation(Required=false)]
        public string ElementType { get; set; }

        /// <summary>
        /// <para>最后修改时间（ISO8601）；被跳过时为 null</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T10:30:00+00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>图谱名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current zone list is illegal.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>操作类型：CREATE / UPDATE（由底层判定）；被跳过时为 null</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE</para>
        /// </summary>
        [NameInMap("operationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>资源名</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>资源大类：object（对象）/ element（业务元素）</para>
        /// 
        /// <b>Example:</b>
        /// <para>object</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
