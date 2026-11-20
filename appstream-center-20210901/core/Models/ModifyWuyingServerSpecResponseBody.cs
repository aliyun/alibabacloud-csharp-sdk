// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyWuyingServerSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The processing result of the specification change.</para>
        /// </summary>
        [NameInMap("ModifyWuyingServerSpecModel")]
        [Validation(Required=false)]
        public ModifyWuyingServerSpecResponseBodyModifyWuyingServerSpecModel ModifyWuyingServerSpecModel { get; set; }
        public class ModifyWuyingServerSpecResponseBodyModifyWuyingServerSpecModel : TeaModel {
            /// <summary>
            /// <para>The ID of the order generated for this specification change. Returning an order ID does not indicate that the specification change is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23429322113****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
