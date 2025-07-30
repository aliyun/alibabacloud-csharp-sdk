// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitParentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The parent organizations.</para>
        /// </summary>
        [NameInMap("Parents")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitParentsResponseBodyParents> Parents { get; set; }
        public class ListOrganizationalUnitParentsResponseBodyParents : TeaModel {
            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_4lag76zc2km5ssg5vsmm2xxxx</para>
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// <para>The parent organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ou_x3beoyepv2ls5iwuge3xhjxxxx</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
