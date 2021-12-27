// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageResponseBody : TeaModel {
        /// <summary>
        /// 返回参数
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeVulListPageResponseBodyData> Data { get; set; }
        public class DescribeVulListPageResponseBodyData : TeaModel {
            /// <summary>
            /// cveId
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 是否安骑士扫描
            /// </summary>
            [NameInMap("IsAegis")]
            [Validation(Required=false)]
            public int? IsAegis { get; set; }

            /// <summary>
            /// 是否网络扫描
            /// </summary>
            [NameInMap("IsSas")]
            [Validation(Required=false)]
            public int? IsSas { get; set; }

            /// <summary>
            /// 编号
            /// </summary>
            [NameInMap("OtherId")]
            [Validation(Required=false)]
            public string OtherId { get; set; }

            /// <summary>
            /// 发布时间
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// 漏洞标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
