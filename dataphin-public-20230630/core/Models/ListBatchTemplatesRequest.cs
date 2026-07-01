// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBatchTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The runtime environment. Default value: PROD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The paged query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListBatchTemplatesRequestListQuery ListQuery { get; set; }
        public class ListBatchTemplatesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The template name keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据处理模板</para>
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
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
