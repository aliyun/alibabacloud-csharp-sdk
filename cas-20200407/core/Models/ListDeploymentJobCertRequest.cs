// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobCertRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment task. You can call the <a href="https://help.aliyun.com/document_detail/2712234.html">CreateDeploymentJob</a> operation to obtain the ID of a deployment task from the <b>JobId</b> parameter. You can also call the <a href="https://help.aliyun.com/document_detail/2712223.html">ListDeploymentJob</a> operation to obtain the ID of a deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

    }

}
