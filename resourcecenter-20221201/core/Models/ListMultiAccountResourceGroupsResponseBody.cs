// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAU5VsT9R1adMTuz9GzginZ3Y+7Y/5JATS+6q5GK9kT75</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FF0A66E-781F-51EE-9531-928F197558F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<ListMultiAccountResourceGroupsResponseBodyResourceGroups> ResourceGroups { get; set; }
        public class ListMultiAccountResourceGroupsResponseBodyResourceGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the management account or member of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1394339739****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T09:20:08Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzawhxxc****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The unique identifier of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The resource group is being created.</description></item>
            /// <item><description>OK: The resource group is created.</description></item>
            /// <item><description>PendingDelete: The resource group is waiting to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
