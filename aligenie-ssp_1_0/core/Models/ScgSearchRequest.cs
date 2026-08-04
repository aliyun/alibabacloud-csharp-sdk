// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchRequest : TeaModel {
        /// <summary>
        /// <para>Query filter</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScgFilter")]
        [Validation(Required=false)]
        public ScgSearchRequestScgFilter ScgFilter { get; set; }
        public class ScgSearchRequestScgFilter : TeaModel {
            /// <summary>
            /// <para>Paging type</para>
            /// </summary>
            [NameInMap("OffSetParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterOffSetParam OffSetParam { get; set; }
            public class ScgSearchRequestScgFilterOffSetParam : TeaModel {
                /// <summary>
                /// <para>Number of returned items</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <para>Number of skipped items</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            /// <summary>
            /// <para>Paging type</para>
            /// </summary>
            [NameInMap("PageParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterPageParam PageParam { get; set; }
            public class ScgSearchRequestScgFilterPageParam : TeaModel {
                /// <summary>
                /// <para>Page number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                /// <summary>
                /// <para>Number of records per page</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// <para>Sorting parameters</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SortParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterSortParam SortParam { get; set; }
            public class ScgSearchRequestScgFilterSortParam : TeaModel {
                /// <summary>
                /// <para>Sorting field</para>
                /// 
                /// <b>Example:</b>
                /// <para>internal_id</para>
                /// </summary>
                [NameInMap("SortKey")]
                [Validation(Required=false)]
                public string SortKey { get; set; }

                /// <summary>
                /// <para>Sorting order</para>
                /// 
                /// <b>Example:</b>
                /// <para>ASC</para>
                /// </summary>
                [NameInMap("SortOrder")]
                [Validation(Required=false)]
                public string SortOrder { get; set; }

                /// <summary>
                /// <para>Sorting field (default: empty string)</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("SortText")]
                [Validation(Required=false)]
                public string SortText { get; set; }

            }

            /// <summary>
            /// <para>Whether to use the pageParam object for paging. Choose either offSetParam or pageParam. The default paging mode is pageParam.</para>
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
        /// <para>Selection pool ID. Optional values: MC201132 (Ethnic Chinese Style), MC201136 (Pop Music), MC201139 (Sweet Love), MC201133 (Folk), MC201137 (Relaxing Reading), MC201138 (Happiness), PA202029 (Stories), PA202030 (Children\&quot;s Songs), PA202028 (Chinese Classics and History), PA202032 (Encyclopedia), PA202031 (English Children\&quot;s Songs)</para>
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
