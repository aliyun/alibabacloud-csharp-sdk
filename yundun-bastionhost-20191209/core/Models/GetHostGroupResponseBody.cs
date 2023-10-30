// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the host group that you want to query.
        /// 
        /// >  You can call the [ListHostGroups](~~201307~~) operation to query the ID of the host group.
        /// </summary>
        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public GetHostGroupResponseBodyHostGroup HostGroup { get; set; }
        public class GetHostGroupResponseBodyHostGroup : TeaModel {
            /// <summary>
            /// The details of the host group returned.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The description of the host group.
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            /// <summary>
            /// The ID of the host group.
            /// </summary>
            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

        }

        /// <summary>
        /// my host group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
