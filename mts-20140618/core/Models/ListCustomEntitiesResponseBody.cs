// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomEntitiesResponseBody : TeaModel {
        [NameInMap("CustomEntities")]
        [Validation(Required=false)]
        public ListCustomEntitiesResponseBodyCustomEntities CustomEntities { get; set; }
        public class ListCustomEntitiesResponseBodyCustomEntities : TeaModel {
            [NameInMap("CustomEntity")]
            [Validation(Required=false)]
            public List<ListCustomEntitiesResponseBodyCustomEntitiesCustomEntity> CustomEntity { get; set; }
            public class ListCustomEntitiesResponseBodyCustomEntitiesCustomEntity : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomEntityId")]
                [Validation(Required=false)]
                public string CustomEntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;finegrainName&quot;:&quot;example&quot; }</para>
                /// </summary>
                [NameInMap("CustomEntityInfo")]
                [Validation(Required=false)]
                public string CustomEntityInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exampleName</para>
                /// </summary>
                [NameInMap("CustomEntityName")]
                [Validation(Required=false)]
                public string CustomEntityName { get; set; }

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
