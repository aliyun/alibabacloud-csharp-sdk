// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateCostRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>924d450014e64e88ac6e8486f8e990**</para>
        /// </summary>
        [NameInMap("CostRuleId")]
        [Validation(Required=false)]
        public string CostRuleId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>580EF224-9647-59E7-9950-D9EBFD6A2921</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
