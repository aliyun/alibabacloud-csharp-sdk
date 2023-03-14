// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostGroupResponseBody : TeaModel {
        /// <summary>
        /// The details of the host group returned.
        /// </summary>
        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public GetHostGroupResponseBodyHostGroup HostGroup { get; set; }
        public class GetHostGroupResponseBodyHostGroup : TeaModel {
            /// <summary>
            /// The description of the host group.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the host group.
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            /// <summary>
            /// The name of the host group.
            /// </summary>
            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
