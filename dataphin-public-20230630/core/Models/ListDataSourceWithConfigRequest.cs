// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataSourceWithConfigRequest : TeaModel {
        /// <summary>
        /// <para>Paginated query</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataSourceWithConfigRequestListQuery ListQuery { get; set; }
        public class ListDataSourceWithConfigRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Data source name</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcns-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Data source owner</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>Page number. The value starts from 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Number of records per page</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Data source scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STREAMING: Real-time</description></item>
            /// <item><description>OFFLINE: Offline</description></item>
            /// <item><description>DIP_META_SYNC: Meta warehouse initialization</description></item>
            /// <item><description>DATA_DISTILL: Data distillation</description></item>
            /// <item><description>CUMPUTE_SOURCE_SHADOW: Shadow compute source</description></item>
            /// <item><description>LABEL: Label</description></item>
            /// <item><description>ALL: Offline + Real-time</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ScopeList")]
            [Validation(Required=false)]
            public List<string> ScopeList { get; set; }

            /// <summary>
            /// <para>Tag marked when creating the data source</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>Data source type</para>
            /// </summary>
            [NameInMap("TypeList")]
            [Validation(Required=false)]
            public List<string> TypeList { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
