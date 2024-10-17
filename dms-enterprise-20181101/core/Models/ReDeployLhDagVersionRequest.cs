// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ReDeployLhDagVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task flow. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to obtain the ID of the task flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The ID of the task flow version. You can call the <a href="https://help.aliyun.com/document_detail/424682.html">ListDAGVersions</a> operation to obtain the ID of the task flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2****</para>
        /// </summary>
        [NameInMap("DagVersion")]
        [Validation(Required=false)]
        public long? DagVersion { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
