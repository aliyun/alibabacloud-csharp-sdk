// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListSchedulesRequest : TeaModel {
        /// <summary>
        /// The name of the flow that is associated with the time-based schedules. The name is unique within the region and cannot be modified after the flow is created. The name must meet the following conventions:
        /// 
        /// *   The name can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (_).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The number of schedules to be queried. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// For the first query, you do not need to specify this parameter. The system uses the value of the **FlowName** parameter as the value of the **NextToken** parameter. When the query ends, no value is returned for this parameter.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
