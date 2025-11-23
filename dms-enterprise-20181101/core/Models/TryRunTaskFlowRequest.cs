// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TryRunTaskFlowRequest : TeaModel {
        /// <summary>
        /// <para>The task flow ID. You can call the <a href="https://help.aliyun.com/document_detail/424565.html">ListTaskFlow</a> or <a href="https://help.aliyun.com/document_detail/426672.html">ListLhTaskFlowAndScenario</a> operation to query the ID of the task flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11****</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

    }

}
