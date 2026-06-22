// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSoarStrategyTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the policy task that is in the waiting state.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2837958.html">DescribeSoarStrategyTasks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11082</para>
        /// </summary>
        [NameInMap("StrategyTaskId")]
        [Validation(Required=false)]
        public long? StrategyTaskId { get; set; }

    }

}
