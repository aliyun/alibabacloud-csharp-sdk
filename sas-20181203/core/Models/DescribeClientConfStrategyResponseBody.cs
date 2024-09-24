// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BD95679-D63A-4151-97D0-188432F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the configurations.</para>
        /// </summary>
        [NameInMap("TargetList")]
        [Validation(Required=false)]
        public List<DescribeClientConfStrategyResponseBodyTargetList> TargetList { get; set; }
        public class DescribeClientConfStrategyResponseBodyTargetList : TeaModel {
            /// <summary>
            /// <para>The UUID of the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b1753a6-04d9-448e-ad17-7abdf19f****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
