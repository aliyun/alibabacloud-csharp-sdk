// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBizEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListBizEntitiesRequestListQuery ListQuery { get; set; }
        public class ListBizEntitiesRequestListQuery : TeaModel {
            [NameInMap("FilterCriteria")]
            [Validation(Required=false)]
            public ListBizEntitiesRequestListQueryFilterCriteria FilterCriteria { get; set; }
            public class ListBizEntitiesRequestListQueryFilterCriteria : TeaModel {
                [NameInMap("BizUnitIdList")]
                [Validation(Required=false)]
                public List<long?> BizUnitIdList { get; set; }

                [NameInMap("BizUnitNameList")]
                [Validation(Required=false)]
                public List<string> BizUnitNameList { get; set; }

                [NameInMap("DataDomainIdList")]
                [Validation(Required=false)]
                public List<long?> DataDomainIdList { get; set; }

                [NameInMap("DataDomainNameList")]
                [Validation(Required=false)]
                public List<string> DataDomainNameList { get; set; }

                [NameInMap("HasTableRef")]
                [Validation(Required=false)]
                public bool? HasTableRef { get; set; }

                [NameInMap("OwnerUserIdList")]
                [Validation(Required=false)]
                public List<string> OwnerUserIdList { get; set; }

                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public List<string> StatusList { get; set; }

                [NameInMap("SubTypeList")]
                [Validation(Required=false)]
                public List<string> SubTypeList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>object_</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
