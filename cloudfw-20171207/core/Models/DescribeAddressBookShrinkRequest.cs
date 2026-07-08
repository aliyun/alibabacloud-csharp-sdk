// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of member accounts for the asset address book.</para>
        /// </summary>
        [NameInMap("AssetMemberUids")]
        [Validation(Required=false)]
        public string AssetMemberUidsShrink { get; set; }

        /// <summary>
        /// <para>Queries address books that contain the specified port. This parameter takes effect only when the <b>GroupType</b> parameter is set to <b>port</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ContainPort")]
        [Validation(Required=false)]
        public string ContainPort { get; set; }

        /// <summary>
        /// <para>The page number in a paged query.</para>
        /// <para>Default value: 1, which indicates that the first page of data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the address book.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, IP address books and ECS tag-based address books are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The unique ID of the address book.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f04ac7ce-628b-4cb7-be61-310222b7****</para>
        /// </summary>
        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// <para>The language type for the address book description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of address books on each page in a paged query.</para>
        /// <para>Default value: 10, which indicates that each page contains 10 results. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The search condition. Enter the address book information that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
