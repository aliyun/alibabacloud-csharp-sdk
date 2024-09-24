// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskListCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of risk items for each cloud service.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskListCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskListCheckResultResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1e8t4q15sr3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The total number of risk items detected in the current cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("riskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BFB4989-A108-46A4-954E-FF7EF02D1078</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
