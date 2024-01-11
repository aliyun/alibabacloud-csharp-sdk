// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMatchedMaliciousNamesResponseBody : TeaModel {
        /// <summary>
        /// 分页查询时，当前页显示的数据条数。
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMatchedMaliciousNamesResponseBodyData> Data { get; set; }
        public class DescribeMatchedMaliciousNamesResponseBodyData : TeaModel {
            /// <summary>
            /// 恶意样本类型显示名称。
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 恶意样本类型Key。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// 本次调用请求的ID，是由阿里云为该请求生成的唯一标识符，可用于排查和定位问题。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
