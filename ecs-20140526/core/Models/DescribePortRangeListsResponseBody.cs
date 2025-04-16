// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePortRangeListsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PortRangeLists")]
        [Validation(Required=false)]
        public List<DescribePortRangeListsResponseBodyPortRangeLists> PortRangeLists { get; set; }
        public class DescribePortRangeListsResponseBodyPortRangeLists : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssociationCount")]
            [Validation(Required=false)]
            public int? AssociationCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-04T07:11Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxEntries")]
            [Validation(Required=false)]
            public int? MaxEntries { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prl-2ze9743****</para>
            /// </summary>
            [NameInMap("PortRangeListId")]
            [Validation(Required=false)]
            public string PortRangeListId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PortRangeListNameSample</para>
            /// </summary>
            [NameInMap("PortRangeListName")]
            [Validation(Required=false)]
            public string PortRangeListName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-2zeg82g****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribePortRangeListsResponseBodyPortRangeListsTags> Tags { get; set; }
            public class DescribePortRangeListsResponseBodyPortRangeListsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6040AD98-11C3-5F78-9346-FCA8E9D8960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
