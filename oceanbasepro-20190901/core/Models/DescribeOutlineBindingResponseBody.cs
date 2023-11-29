// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOutlineBindingResponseBody : TeaModel {
        /// <summary>
        /// The binding information.
        /// </summary>
        [NameInMap("OutlineBinding")]
        [Validation(Required=false)]
        public DescribeOutlineBindingResponseBodyOutlineBinding OutlineBinding { get; set; }
        public class DescribeOutlineBindingResponseBodyOutlineBinding : TeaModel {
            /// <summary>
            /// The bound index.
            /// </summary>
            [NameInMap("BindIndex")]
            [Validation(Required=false)]
            public string BindIndex { get; set; }

            /// <summary>
            /// The bound plan.
            /// </summary>
            [NameInMap("BindPlan")]
            [Validation(Required=false)]
            public string BindPlan { get; set; }

            /// <summary>
            /// The maximum number of concurrent tasks.
            /// </summary>
            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public int? MaxConcurrent { get; set; }

            /// <summary>
            /// OutlineID.
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// 表名称
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
