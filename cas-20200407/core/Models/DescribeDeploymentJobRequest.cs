// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment job. To get the job ID, call the <a href="https://help.aliyun.com/document_detail/2712234.html">CreateDeploymentJob</a> or <a href="https://help.aliyun.com/document_detail/2712223.html">ListDeploymentJob</a> operation.</para>
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
