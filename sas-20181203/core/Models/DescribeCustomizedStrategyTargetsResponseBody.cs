// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizedStrategyTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of target information for the custom policy.</para>
        /// </summary>
        [NameInMap("StartegyTargets")]
        [Validation(Required=false)]
        public List<DescribeCustomizedStrategyTargetsResponseBodyStartegyTargets> StartegyTargets { get; set; }
        public class DescribeCustomizedStrategyTargetsResponseBodyStartegyTargets : TeaModel {
            /// <summary>
            /// <para>The ID of the server group.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query server group IDs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>14590457</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The ID of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1884</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// <para>The name of the baseline check policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>白名单</para>
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2701ad2e-0e8f-428c-8812-ebb2686e****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
