// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateWorkerResourceStatusRequest : TeaModel {
        /// <summary>
        /// <para>The deployment task ID. This ID is returned by <a href="https://help.aliyun.com/document_detail/2712234.html">CreateDeploymentJob</a>. You can also obtain it by calling <a href="https://help.aliyun.com/document_detail/2712223.html">ListDeploymentJob</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The target status. Valid values: &quot;editing&quot;, &quot;pending&quot;, &quot;success&quot;, &quot;rollback&quot;, &quot;rollback_success&quot;, &quot;rollback_error&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rollback</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The deployment task worker ID. You can obtain this ID by calling <a href="https://help.aliyun.com/document_detail/2712224.html">ListWorkerResource</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkerId")]
        [Validation(Required=false)]
        public long? WorkerId { get; set; }

    }

}
