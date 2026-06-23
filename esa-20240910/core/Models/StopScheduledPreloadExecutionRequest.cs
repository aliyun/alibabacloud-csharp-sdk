// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class StopScheduledPreloadExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The prefetch plan ID. You can obtain this value from the SuccessExecutions[].Id field returned by CreateScheduledPreloadExecutions. Before calling this operation, create a prefetch job by calling CreateScheduledPreloadJob, and then create an execution plan by calling CreateScheduledPreloadExecutions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66599bd7397885b43804901c</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
