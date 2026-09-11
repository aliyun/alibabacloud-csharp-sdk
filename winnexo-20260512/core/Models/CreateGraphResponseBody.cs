// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGraphResponseBody : TeaModel {
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
        /// <para>创建时绑定的数据源 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>198001</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

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
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>Schema 版本；快建路径固定 0.0.0，正式版本经控制台发布产生</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>同步状态，快建成功为 SUCCESS</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("syncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

    }

}
