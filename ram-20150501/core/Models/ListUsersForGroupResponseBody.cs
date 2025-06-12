// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListUsersForGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The marker. This parameter is returned only if the value of <c>IsTruncated</c> is <c>true</c>. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.````</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B450CA1-36E8-4AA2-8461-86B42BF4CC4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersForGroupResponseBodyUsers Users { get; set; }
        public class ListUsersForGroupResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersForGroupResponseBodyUsersUser> User { get; set; }
            public class ListUsersForGroupResponseBodyUsersUser : TeaModel {
                /// <summary>
                /// <para>The display name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The time when the RAM user joined the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("JoinDate")]
                [Validation(Required=false)]
                public string JoinDate { get; set; }

                /// <summary>
                /// <para>The name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangqiang</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
