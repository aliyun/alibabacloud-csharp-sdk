// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteLhMembersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user to be removed. You can call the <a href="https://help.aliyun.com/document_detail/141938.html">ListUsers</a> or <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> operation to obtain the user ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberIds")]
        [Validation(Required=false)]
        public List<int?> MemberIds { get; set; }

        /// <summary>
        /// <para>The ID of the object.</para>
        /// <list type="bullet">
        /// <item><description>If the object is a workspace, you can call the <a href="https://help.aliyun.com/document_detail/424379.html">GetLhSpaceByName</a> operation to obtain the workspace ID.</description></item>
        /// <item><description>If the object is a task flow, you can call the <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to obtain the task flow ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9***</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public long? ObjectId { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: workspace</description></item>
        /// <item><description><b>1</b>: task flow</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
