// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the network instances.</para>
        /// </summary>
        [NameInMap("NetworkInstanceList")]
        [Validation(Required=false)]
        public List<DescribeNetworkInstanceListResponseBodyNetworkInstanceList> NetworkInstanceList { get; set; }
        public class DescribeNetworkInstanceListResponseBodyNetworkInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m5ewlqkuf7or****</para>
            /// </summary>
            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("NetworkInstanceName")]
            [Validation(Required=false)]
            public string NetworkInstanceName { get; set; }

            /// <summary>
            /// <para>The type of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("NetworkInstanceType")]
            [Validation(Required=false)]
            public string NetworkInstanceType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2373503-3921-59F2-93A6-3DA7FB7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
