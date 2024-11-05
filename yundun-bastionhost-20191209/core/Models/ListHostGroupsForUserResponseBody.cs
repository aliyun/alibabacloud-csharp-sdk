// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The host groups returned.</para>
        /// </summary>
        [NameInMap("HostGroups")]
        [Validation(Required=false)]
        public List<ListHostGroupsForUserResponseBodyHostGroups> HostGroups { get; set; }
        public class ListHostGroupsForUserResponseBodyHostGroups : TeaModel {
            /// <summary>
            /// <para>The remarks of the host group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The host group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>１</para>
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            /// <summary>
            /// <para>The name of the host group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of host groups returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
