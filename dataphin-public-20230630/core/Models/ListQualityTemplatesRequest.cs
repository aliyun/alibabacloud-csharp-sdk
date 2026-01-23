// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityTemplatesRequest : TeaModel {
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityTemplatesRequestListQuery ListQuery { get; set; }
        public class ListQualityTemplatesRequestListQuery : TeaModel {
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("SupportDataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> SupportDataSourceTypeList { get; set; }

            [NameInMap("TemplateOwnerList")]
            [Validation(Required=false)]
            public List<string> TemplateOwnerList { get; set; }

            [NameInMap("TemplateSourceList")]
            [Validation(Required=false)]
            public List<string> TemplateSourceList { get; set; }

            [NameInMap("TemplateTypeList")]
            [Validation(Required=false)]
            public List<string> TemplateTypeList { get; set; }

            [NameInMap("WatchTypeList")]
            [Validation(Required=false)]
            public List<string> WatchTypeList { get; set; }

        }

        /// <summary>
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
