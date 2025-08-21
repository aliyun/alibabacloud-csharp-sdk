// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScgFilter")]
        [Validation(Required=false)]
        public ScgSearchRequestScgFilter ScgFilter { get; set; }
        public class ScgSearchRequestScgFilter : TeaModel {
            [NameInMap("OffSetParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterOffSetParam OffSetParam { get; set; }
            public class ScgSearchRequestScgFilterOffSetParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            [NameInMap("PageParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterPageParam PageParam { get; set; }
            public class ScgSearchRequestScgFilterPageParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SortParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterSortParam SortParam { get; set; }
            public class ScgSearchRequestScgFilterSortParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>internal_id</para>
                /// </summary>
                [NameInMap("SortKey")]
                [Validation(Required=false)]
                public string SortKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ASC</para>
                /// </summary>
                [NameInMap("SortOrder")]
                [Validation(Required=false)]
                public string SortOrder { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SortText")]
                [Validation(Required=false)]
                public string SortText { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseOffSet")]
            [Validation(Required=false)]
            public bool? UseOffSet { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MC201132</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

    }

}
