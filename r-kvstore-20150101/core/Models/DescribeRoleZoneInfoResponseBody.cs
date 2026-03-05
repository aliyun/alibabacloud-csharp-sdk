// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyNode Node { get; set; }
        public class DescribeRoleZoneInfoResponseBodyNode : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyNodeNodeInfo> NodeInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyNodeNodeInfo : TeaModel {
                [NameInMap("CurrentBandWidth")]
                [Validation(Required=false)]
                public long? CurrentBandWidth { get; set; }

                [NameInMap("CurrentMinorVersion")]
                [Validation(Required=false)]
                public string CurrentMinorVersion { get; set; }

                [NameInMap("CustinsId")]
                [Validation(Required=false)]
                public string CustinsId { get; set; }

                [NameInMap("DefaultBandWidth")]
                [Validation(Required=false)]
                public long? DefaultBandWidth { get; set; }

                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                [NameInMap("InsType")]
                [Validation(Required=false)]
                public int? InsType { get; set; }

                [NameInMap("IsLatestVersion")]
                [Validation(Required=false)]
                public int? IsLatestVersion { get; set; }

                [NameInMap("IsOpenBandWidthService")]
                [Validation(Required=false)]
                public bool? IsOpenBandWidthService { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224B97FB-A275-4EAC-86E9-8922FEA2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
