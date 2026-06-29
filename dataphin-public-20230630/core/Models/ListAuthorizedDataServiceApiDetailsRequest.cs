// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAuthorizedDataServiceApiDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The query request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListAuthorizedDataServiceApiDetailsRequestListQuery ListQuery { get; set; }
        public class ListAuthorizedDataServiceApiDetailsRequestListQuery : TeaModel {
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
            /// <para>The page number, starting from 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Maximum value: 100.</para>
            /// <para>This parameter is required.</para>
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

    }

}
