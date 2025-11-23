// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskContentV2Request : TeaModel {
        /// <summary>
        /// <para>The node configurations after modification.</para>
        /// <remarks>
        /// <para> We recommend that you change the SQL type from SELECT to INSERT/CREATE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;dbId&quot;:12****, &quot;sql&quot;:&quot;select * from test_table&quot;,   &quot;dbType&quot;:&quot;lindorm_sql&quot;  }</para>
        /// </summary>
        [NameInMap("NodeContent")]
        [Validation(Required=false)]
        public string NodeContent { get; set; }

        /// <summary>
        /// <para>The ID of the task node. You can call the <a href="https://help.aliyun.com/document_detail/424711.html">GetTaskInstanceRelation</a> operation to query the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>449***</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
