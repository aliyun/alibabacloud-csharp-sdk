// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceCountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The filter condition.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceCountsResponseBodyFilters> Filters { get; set; }
        public class GetMultiAccountResourceCountsResponseBodyFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The dimension by which resources are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFA806B9-7F36-55AB-8B7A-D680C2C5EE57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The numbers of resources.</para>
        /// </summary>
        [NameInMap("ResourceCounts")]
        [Validation(Required=false)]
        public List<GetMultiAccountResourceCountsResponseBodyResourceCounts> ResourceCounts { get; set; }
        public class GetMultiAccountResourceCountsResponseBodyResourceCounts : TeaModel {
            /// <summary>
            /// <para>The number of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::NetworkInterface</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

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
