// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionOccupancyOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePhysicalConnectionOccupancyOrderResponseBodyData Data { get; set; }
        public class CreatePhysicalConnectionOccupancyOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the order that is placed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50187055895****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B9300FE-11E2-4E3B-949C-BED3B44DD26D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
