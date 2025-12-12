// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeEventMetaInfoResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEventMetaInfoResponseBodyItems> Items { get; set; }
        public class DescribeEventMetaInfoResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Task.TaskStatus</para>
            /// </summary>
            [NameInMap("SourceCode")]
            [Validation(Required=false)]
            public string SourceCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>94F92113-FF63-5E57-8401-6FE123AD11DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
