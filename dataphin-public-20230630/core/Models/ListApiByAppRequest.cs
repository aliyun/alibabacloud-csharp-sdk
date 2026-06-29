// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListApiByAppRequest : TeaModel {
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
        /// <para>The paged query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PageQuery")]
        [Validation(Required=false)]
        public ListApiByAppRequestPageQuery PageQuery { get; set; }
        public class ListApiByAppRequestPageQuery : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The application key.</para>
            /// <remarks>
            /// <para>Notice: Deprecated. Use AppKeyStr instead.</notice>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            [Obsolete]
            public long? AppKey { get; set; }

            /// <summary>
            /// <para>The application key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_200000000</para>
            /// </summary>
            [NameInMap("AppKeyStr")]
            [Validation(Required=false)]
            public string AppKeyStr { get; set; }

            /// <summary>
            /// <para>The keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiName</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

    }

}
