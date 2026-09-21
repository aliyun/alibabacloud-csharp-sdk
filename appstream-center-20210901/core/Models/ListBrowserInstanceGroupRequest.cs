// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The browser group set ID for exact match queries of active members in the set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>set-3jm9d0abc00example</para>
        /// </summary>
        [NameInMap("AppInstanceGroupSetId")]
        [Validation(Required=false)]
        public string AppInstanceGroupSetId { get; set; }

        /// <summary>
        /// <para>Filters browser groups by business region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The cloud browser group ID for exact match queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0c7loey7fzjq****</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The browser group name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupName")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupName { get; set; }

        /// <summary>
        /// <para>Performs a contains match by browser group name or ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>Excludes browser groups that are authorized to the specified user groups.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExcludedUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ExcludedUserGroupIds { get; set; }

        /// <summary>
        /// <para>Filters browser groups by office network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-843734****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The page number, starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by browser group status.</para>
        /// <para><b>Limit:</b> Only one status value can be specified at a time.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The tag filter parameters. This parameter is not supported in customer-facing scenarios. Do not specify this parameter.</para>
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
        /// <para>Filters by version of the browser.</para>
        /// <list type="bullet">
        /// <item><description><c>Basic</c>: Basic Edition.</description></item>
        /// <item><description><c>Pro</c>: Premium Edition.</description></item>
        /// </list>
        /// <para>Use <c>Pro</c> to query MAU browser groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("Tier")]
        [Validation(Required=false)]
        public string Tier { get; set; }

        /// <summary>
        /// <para>Filters by authorized user group IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
