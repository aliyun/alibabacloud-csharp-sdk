// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU+SQXzm0H9mu/FiSc****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NodeModel")]
        [Validation(Required=false)]
        public List<DescribeCloudPhoneNodesResponseBodyNodeModel> NodeModel { get; set; }
        public class DescribeCloudPhoneNodesResponseBodyNodeModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-13 02:03:14</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-09 02:00:34</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public string GmtExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-02-13 02:03:14</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-5mwr9azebliva****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cpn-ehs0yoedq8ntm****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_name</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("PhoneCount")]
            [Validation(Required=false)]
            public int? PhoneCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cpm.gn6.gx1</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ShareDataVolume")]
            [Validation(Required=false)]
            public int? ShareDataVolume { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-2zeekryyc1q3sm72l****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F07A1DA1-E1EB-5CCA-8EED-12F85D32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
