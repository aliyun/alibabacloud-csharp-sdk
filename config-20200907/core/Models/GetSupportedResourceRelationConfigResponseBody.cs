// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetSupportedResourceRelationConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>409D022F-394C-5AAB-A74A-2F1DC9F6375E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that contains the relationships.</para>
        /// </summary>
        [NameInMap("ResourceRelationConfigList")]
        [Validation(Required=false)]
        public List<GetSupportedResourceRelationConfigResponseBodyResourceRelationConfigList> ResourceRelationConfigList { get; set; }
        public class GetSupportedResourceRelationConfigResponseBodyResourceRelationConfigList : TeaModel {
            /// <summary>
            /// <para>The type of the relationship between the resource and the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IsContained: The object is included as part of the resource.</description></item>
            /// <item><description>IsAttachedTo: The object is added to the resource.</description></item>
            /// <item><description>IsAssociatedIn: The object is associated with the resource.</description></item>
            /// <item><description>Contains: The actual value contains the expected value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IsAttachedTo</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Disk</para>
            /// </summary>
            [NameInMap("TargetResourceType")]
            [Validation(Required=false)]
            public string TargetResourceType { get; set; }

        }

    }

}
