// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInstanceSpecsResponseBodyResult> Result { get; set; }
        public class ListInstanceSpecsResponseBodyResult : TeaModel {
            /// <summary>
            /// None
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// 单数据节点存储空间最大值
            /// </summary>
            [NameInMap("maxDisk")]
            [Validation(Required=false)]
            public int? MaxDisk { get; set; }

            /// <summary>
            /// Unit: GB
            /// </summary>
            [NameInMap("mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// 单数据节点存储空间最小值
            /// </summary>
            [NameInMap("minDisk")]
            [Validation(Required=false)]
            public int? MinDisk { get; set; }

        }

    }

}
