// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAmountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyNodePoolAmountResponseBodyData Data { get; set; }
        public class ModifyNodePoolAmountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>23429322113****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
