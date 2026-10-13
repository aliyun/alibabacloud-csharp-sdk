// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelRecycleBinJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task that you want to cancel.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2412172.html">ListRecycleBinJobs</a> operation to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rb-15<b><b>ed-r-1625</b></b>2441</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
