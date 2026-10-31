// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataSourceWithConfigRequest : TeaModel {
        /// <summary>
        /// <para>The paged query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataSourceWithConfigRequestListQuery ListQuery { get; set; }
        public class ListDataSourceWithConfigRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcns-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owners of the data sources.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>The page number. The starting page is 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The usage scopes of the data sources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STREAMING: Real-time.</description></item>
            /// <item><description>OFFLINE: Offline.</description></item>
            /// <item><description>DIP_META_SYNC: Metadata warehouse initialization.</description></item>
            /// <item><description>DATA_DISTILL: Data distillation.</description></item>
            /// <item><description>CUMPUTE_SOURCE_SHADOW: Shadow compute source.</description></item>
            /// <item><description>LABEL: Label.</description></item>
            /// <item><description>ALL: Offline and real-time.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>The tag specified during data source creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The data source types.</para>
            /// </summary>
            [NameInMap("TypeList")]
            [Validation(Required=false)]
            public List<string> TypeList { get; set; }

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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
