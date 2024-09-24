// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001BAB34-D70A-54B0-B1D7-91B76DCDD8E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the assets to which the baseline check policy is applied.</para>
        /// </summary>
        [NameInMap("StrategyTargets")]
        [Validation(Required=false)]
        public List<DescribeStrategyTargetResponseBodyStrategyTargets> StrategyTargets { get; set; }
        public class DescribeStrategyTargetResponseBodyStrategyTargets : TeaModel {
            /// <summary>
            /// <para>The number of the assets that belong to the asset group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("BindUuidCount")]
            [Validation(Required=false)]
            public int? BindUuidCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline check policy is applied to the asset group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: The baseline check policy is applied to the asset group.</description></item>
            /// <item><description><b>del</b>: the baseline check policy is not applied to the asset group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The ID of the asset group to which the assets belong or the UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9165712</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The method that is used to add the assets to the baseline check policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>groupId</b>: the ID of the asset group</description></item>
            /// <item><description><b>uuid</b>: the UUID of the asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>groupId</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
