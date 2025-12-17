// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery group.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModel")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupResponseBodyAppInstanceGroupModel AppInstanceGroupModel { get; set; }
        public class CreateAppInstanceGroupResponseBodyAppInstanceGroupModel : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. This parameter is returned if a resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ew7va2g1wl3vm****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
