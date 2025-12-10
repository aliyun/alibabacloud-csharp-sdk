// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsWithAuthDetailsResponseBody : TeaModel {
        [NameInMap("AuthDetails")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsResponseBodyAuthDetails> AuthDetails { get; set; }
        public class ListResourceGroupsWithAuthDetailsResponseBodyAuthDetails : TeaModel {
            [NameInMap("AccountScopeAuth")]
            [Validation(Required=false)]
            public bool? AccountScopeAuth { get; set; }

            [NameInMap("AuthOfResourceGroups")]
            [Validation(Required=false)]
            public List<ListResourceGroupsWithAuthDetailsResponseBodyAuthDetailsAuthOfResourceGroups> AuthOfResourceGroups { get; set; }
            public class ListResourceGroupsWithAuthDetailsResponseBodyAuthDetailsAuthOfResourceGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasPermission")]
                [Validation(Required=false)]
                public bool? HasPermission { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aekzscexx6w3u2y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsResponseBodyResourceGroups> ResourceGroups { get; set; }
        public class ListResourceGroupsWithAuthDetailsResponseBodyResourceGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-9gLOoK****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourceGroupsWithAuthDetailsResponseBodyResourceGroupsTags> Tags { get; set; }
            public class ListResourceGroupsWithAuthDetailsResponseBodyResourceGroupsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
