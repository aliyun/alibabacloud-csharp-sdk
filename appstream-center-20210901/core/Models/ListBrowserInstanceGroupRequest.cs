// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the browser group set. This parameter is used to query the valid members of the set by exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>Filters cloud browser groups by business region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud browser group. This parameter is used for exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0c7loey7fzjq****</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the browser group. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupName")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupName { get; set; }

        /// <summary>
        /// <para>Filters cloud browser groups by name or ID based on partial match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>Excludes cloud browser groups that are authorized to the specified user groups.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExcludedUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ExcludedUserGroupIds { get; set; }

        /// <summary>
        /// <para>Filters cloud browser groups by the ID of the office network to which they belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-843734****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters cloud browser groups by status.</para>
        /// <para><b>Limit:</b> You can specify only one status at a time.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tag filtering parameter. This parameter is not supported in customer-facing scenarios. Do not specify this parameter.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListBrowserInstanceGroupRequestTag> Tag { get; set; }
        public class ListBrowserInstanceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Do not specify this parameter in customer-facing scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Do not specify this parameter in customer-facing scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Filters cloud browser groups by browser version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Basic</c>: Basic Edition.</description></item>
        /// <item><description><c>Pro</c>: Premium Edition.</description></item>
        /// </list>
        /// <para>Use <c>Pro</c> when you query MAU browser groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("Tier")]
        [Validation(Required=false)]
        public string Tier { get; set; }

        /// <summary>
        /// <para>Filters cloud browser groups by the IDs of authorized user groups.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
