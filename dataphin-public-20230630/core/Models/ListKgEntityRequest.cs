// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListKgEntityRequest : TeaModel {
        /// <summary>
        /// <para>The entity type code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Company</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The paged query filter conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListKgEntityRequestListQuery ListQuery { get; set; }
        public class ListKgEntityRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The property filter conditions.</para>
            /// </summary>
            [NameInMap("FilterList")]
            [Validation(Required=false)]
            public List<ListKgEntityRequestListQueryFilterList> FilterList { get; set; }
            public class ListKgEntityRequestListQueryFilterList : TeaModel {
                /// <summary>
                /// <para>The operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>eq: equal to.</description></item>
                /// <item><description>neq: not equal to.</description></item>
                /// <item><description>contains: contains.</description></item>
                /// <item><description>gt: greater than.</description></item>
                /// <item><description>gte: greater than or equal to.</description></item>
                /// <item><description>lt: less than.</description></item>
                /// <item><description>lte: less than or equal to.</description></item>
                /// <item><description>like: fuzzy match.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The property code.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company_name</para>
                /// </summary>
                [NameInMap("PropertyCode")]
                [Validation(Required=false)]
                public string PropertyCode { get; set; }

                /// <summary>
                /// <para>The property match value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The keyword for searching display properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
