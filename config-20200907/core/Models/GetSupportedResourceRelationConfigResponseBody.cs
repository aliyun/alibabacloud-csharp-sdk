// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetSupportedResourceRelationConfigResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported resource relationships.
        /// </summary>
        [NameInMap("ResourceRelationConfigList")]
        [Validation(Required=false)]
        public List<GetSupportedResourceRelationConfigResponseBodyResourceRelationConfigList> ResourceRelationConfigList { get; set; }
        public class GetSupportedResourceRelationConfigResponseBodyResourceRelationConfigList : TeaModel {
            /// <summary>
            /// The relationship type.
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("TargetResourceType")]
            [Validation(Required=false)]
            public string TargetResourceType { get; set; }

        }

    }

}
