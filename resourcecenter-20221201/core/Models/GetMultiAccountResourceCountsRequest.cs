// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceCountsRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceCountsRequestFilter> Filter { get; set; }
        public class GetMultiAccountResourceCountsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. For more information, see <c>Supported filter parameters</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method.</para>
            /// <para>Set the value to Equals, which indicates an exact match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The dimension by which resources are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ResourceType: resource type</para>
        /// </description></item>
        /// <item><description><para>RegionId: region</para>
        /// </description></item>
        /// <item><description><para>ResourceGroupId: resource group</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not configured, the total number of resources that meet the conditions is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// <para>The search scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ID of a resource directory: Resources within the management account and all members of the resource directory are searched.</para>
        /// </description></item>
        /// <item><description><para>ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched.</para>
        /// </description></item>
        /// <item><description><para>ID of a folder: Resources within all members in the folder are searched.</para>
        /// </description></item>
        /// <item><description><para>ID of a member: Resources within the member are searched.</para>
        /// </description></item>
        /// </list>
        /// <para>For information about how to obtain the ID of a resource directory, the Root folder, a folder, or a member, see <a href="https://help.aliyun.com/document_detail/159995.html">GetResourceDirectory</a>, <a href="https://help.aliyun.com/document_detail/159997.html">ListFoldersForParent</a>, or <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
