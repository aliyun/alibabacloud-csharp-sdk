// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomGroupsResponseBody : TeaModel {
        [NameInMap("CustomGroups")]
        [Validation(Required=false)]
        public ListCustomGroupsResponseBodyCustomGroups CustomGroups { get; set; }
        public class ListCustomGroupsResponseBodyCustomGroups : TeaModel {
            [NameInMap("CustomGroup")]
            [Validation(Required=false)]
            public List<ListCustomGroupsResponseBodyCustomGroupsCustomGroup> CustomGroup { get; set; }
            public class ListCustomGroupsResponseBodyCustomGroupsCustomGroup : TeaModel {
                [NameInMap("CustomGroupDescription")]
                [Validation(Required=false)]
                public string CustomGroupDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomGroupId")]
                [Validation(Required=false)]
                public string CustomGroupId { get; set; }

                [NameInMap("CustomGroupName")]
                [Validation(Required=false)]
                public string CustomGroupName { get; set; }

            }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>580e8ce3-3b80-44c5-9f3f-36ac3cc5bdd5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
