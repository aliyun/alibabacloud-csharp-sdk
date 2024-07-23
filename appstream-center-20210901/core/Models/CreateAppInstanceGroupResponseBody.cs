// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupResponseBody : TeaModel {
        [NameInMap("AppInstanceGroupModel")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupResponseBodyAppInstanceGroupModel AppInstanceGroupModel { get; set; }
        public class CreateAppInstanceGroupResponseBodyAppInstanceGroupModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-ew7va2g1wl3vm****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
