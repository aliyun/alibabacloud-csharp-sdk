// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskOutputRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the node. You can call the <a href="https://help.aliyun.com/document_detail/424711.html">GetTaskInstanceRelation</a> operation to query the node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14059</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The output variables for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“outputs”:[{&quot;row&quot;:0, &quot;column&quot;:-1,&quot;combiner&quot;:&quot;,&quot;}&quot;extractMethod&quot;:&quot;{\&quot;row\&quot;:0,\&quot;column\&quot;:-1,\&quot;combiner\&quot;:\&quot;,\&quot;}&quot;,   &quot;variableName&quot;:&quot;var&quot;, &quot;description&quot;:&quot;For demo&quot; }]}</para>
        /// </summary>
        [NameInMap("NodeOutput")]
        [Validation(Required=false)]
        public string NodeOutput { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
