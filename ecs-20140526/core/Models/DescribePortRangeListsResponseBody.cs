// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePortRangeListsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. If the return value is empty, no more data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Details of the port lists.</para>
        /// </summary>
        [NameInMap("PortRangeLists")]
        [Validation(Required=false)]
        public List<DescribePortRangeListsResponseBodyPortRangeLists> PortRangeLists { get; set; }
        public class DescribePortRangeListsResponseBodyPortRangeLists : TeaModel {
            /// <summary>
            /// <para>The number of associated resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssociationCount")]
            [Validation(Required=false)]
            public int? AssociationCount { get; set; }

            /// <summary>
            /// <para>The time when the port list was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-04T07:11Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maximum number of entries in the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            /// <summary>
            /// <para>The ID of the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prl-2ze9743****</para>
            /// </summary>
            [NameInMap("PortRangeListId")]
            [Validation(Required=false)]
            public string PortRangeListId { get; set; }

            /// <summary>
            /// <para>The name of the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PortRangeListNameSample</para>
            /// </summary>
            [NameInMap("PortRangeListName")]
            [Validation(Required=false)]
            public string PortRangeListName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which to assign the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-2zeg82g****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags of the port list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribePortRangeListsResponseBodyPortRangeListsTags> Tags { get; set; }
            public class DescribePortRangeListsResponseBodyPortRangeListsTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6040AD98-11C3-5F78-9346-FCA8E9D8960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
