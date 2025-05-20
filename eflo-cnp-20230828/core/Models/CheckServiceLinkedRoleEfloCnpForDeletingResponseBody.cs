// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CheckServiceLinkedRoleEfloCnpForDeletingResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the SLR can be deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The SLR can be deleted.</description></item>
        /// <item><description><c>false</c>: The SLR cannot be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Deletable")]
        [Validation(Required=false)]
        public bool? Deletable { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C212C4A-2CB3-56E6-BA2F-1CE2B03C5C94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CheckServiceLinkedRoleEfloCnpForDeletingResponseBodyResources> Resources { get; set; }
        public class CheckServiceLinkedRoleEfloCnpForDeletingResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The resources.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

    }

}
