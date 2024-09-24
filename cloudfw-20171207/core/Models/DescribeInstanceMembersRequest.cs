// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceMembersRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The remarks of the member. The remarks must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>renewal</para>
        /// </summary>
        [NameInMap("MemberDesc")]
        [Validation(Required=false)]
        public string MemberDesc { get; set; }

        /// <summary>
        /// <para>The name of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewall_2</para>
        /// </summary>
        [NameInMap("MemberDisplayName")]
        [Validation(Required=false)]
        public string MemberDisplayName { get; set; }

        /// <summary>
        /// <para>The UID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
