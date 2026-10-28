// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateBrowserInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation result of the cloud browser group, including the resource ID and the order ID.</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupModel")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupResponseBodyBrowserInstanceGroupModel BrowserInstanceGroupModel { get; set; }
        public class CreateBrowserInstanceGroupResponseBodyBrowserInstanceGroupModel : TeaModel {
            /// <summary>
            /// <para>The ID of the newly created cloud browser group. The return of this ID does not indicate that the resource is ready.</para>
            /// 
            /// <b>Example:</b>
            /// <para>big-0bz55ixxxxx9xi9w9</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupId")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The order ID generated for this creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
