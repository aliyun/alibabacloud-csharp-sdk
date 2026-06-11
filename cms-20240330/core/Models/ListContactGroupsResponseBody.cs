// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListContactGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of contact groups.</para>
        /// </summary>
        [NameInMap("contactGroups")]
        [Validation(Required=false)]
        public List<ListContactGroupsResponseBodyContactGroups> ContactGroups { get; set; }
        public class ListContactGroupsResponseBodyContactGroups : TeaModel {
            /// <summary>
            /// <para>The contact group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("contactGroupId")]
            [Validation(Required=false)]
            public string ContactGroupId { get; set; }

            /// <summary>
            /// <para>The contact IDs in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Demo meeting&quot;]</para>
            /// </summary>
            [NameInMap("contactIds")]
            [Validation(Required=false)]
            public List<string> ContactIds { get; set; }

            /// <summary>
            /// <para>The name of the contact group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The returned page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
