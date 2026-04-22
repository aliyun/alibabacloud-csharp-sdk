// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeIntranetUserCanAnalysisVpcsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("CurPage")]
        [Validation(Required=false)]
        public int? CurPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C6F1D541-E7A6-447A-A2B5-9F7A20B2A8FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

        [NameInMap("UserCanAnalysisVpcsPopResults")]
        [Validation(Required=false)]
        public DescribeIntranetUserCanAnalysisVpcsResponseBodyUserCanAnalysisVpcsPopResults UserCanAnalysisVpcsPopResults { get; set; }
        public class DescribeIntranetUserCanAnalysisVpcsResponseBodyUserCanAnalysisVpcsPopResults : TeaModel {
            [NameInMap("UserCanAnalysisVpcsPopResult")]
            [Validation(Required=false)]
            public List<DescribeIntranetUserCanAnalysisVpcsResponseBodyUserCanAnalysisVpcsPopResultsUserCanAnalysisVpcsPopResult> UserCanAnalysisVpcsPopResult { get; set; }
            public class DescribeIntranetUserCanAnalysisVpcsResponseBodyUserCanAnalysisVpcsPopResultsUserCanAnalysisVpcsPopResult : TeaModel {
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("AuthorizedUserId")]
                [Validation(Required=false)]
                public long? AuthorizedUserId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("TreeLevel")]
                [Validation(Required=false)]
                public int? TreeLevel { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

            }

        }

    }

}
