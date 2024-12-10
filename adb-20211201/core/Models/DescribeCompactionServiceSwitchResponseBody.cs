// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeCompactionServiceSwitchResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCompactionServiceSwitchResponseBodyData Data { get; set; }
        public class DescribeCompactionServiceSwitchResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCompactionService")]
            [Validation(Required=false)]
            public bool? EnableCompactionService { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D761DA51-12F8-5457-AAA9-F52B9F436D2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
