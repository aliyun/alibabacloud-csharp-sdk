// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class CheckCreateClusterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckCreateClusterResponseBodyData Data { get; set; }
        public class CheckCreateClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("ExpectedDBClusterStatus")]
            [Validation(Required=false)]
            public string ExpectedDBClusterStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ExpectedOrderFinishSeconds")]
            [Validation(Required=false)]
            public long? ExpectedOrderFinishSeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("ExpectedTargetVirtualWareHouseStatus")]
            [Validation(Required=false)]
            public string ExpectedTargetVirtualWareHouseStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9A23C87D-87DF-4DA0-A50E-CB13F4F7923D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
