// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class CheckModifyVirtualWareHouseResourceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckModifyVirtualWareHouseResourceResponseBodyData Data { get; set; }
        public class CheckModifyVirtualWareHouseResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ResourceChanging</para>
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
            /// <para>ResourceChanging</para>
            /// </summary>
            [NameInMap("ExpectedTargetVirtualWareHouseStatus")]
            [Validation(Required=false)]
            public string ExpectedTargetVirtualWareHouseStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05321590-BB65-4720-8CB6-8218E041CDD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
