// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListScheduledPlanExecutedHistoryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58718c99-3b29-4c5e-93bb-c9fc4ec6****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SCHEDULED_PLAN</para>
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

    }

}
