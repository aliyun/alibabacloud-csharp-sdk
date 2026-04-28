// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyCostRuleResponseBody : TeaModel {
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
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
