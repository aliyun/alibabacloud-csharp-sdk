// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateWuyingServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWuyingServerResponseBodyData Data { get; set; }
        public class CreateWuyingServerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23429322113****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The list of workstation IDs.</para>
            /// <para><b>If AutoPay is set to false and the order is unpaid, these IDs are the workstation IDs pre-allocated for the order. The actual workstations are not yet created, and you cannot use these IDs to perform deletion or other resource operations.</b> Pay the order corresponding to the returned OrderId first, and then call ListWuyingServer to confirm that the workstations are created and check their current status.
            /// <a href="~~ListWuyingServer~~">ListWuyingServer</a></para>
            /// </summary>
            [NameInMap("WuyingServerIdList")]
            [Validation(Required=false)]
            public List<string> WuyingServerIdList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
