// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBizEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The query request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListBizEntitiesRequestListQuery ListQuery { get; set; }
        public class ListBizEntitiesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The filter criteria for the query.</para>
            /// </summary>
            [NameInMap("FilterCriteria")]
            [Validation(Required=false)]
            public ListBizEntitiesRequestListQueryFilterCriteria FilterCriteria { get; set; }
            public class ListBizEntitiesRequestListQueryFilterCriteria : TeaModel {
                /// <summary>
                /// <para>The IDs of the business units.</para>
                /// </summary>
                [NameInMap("BizUnitIdList")]
                [Validation(Required=false)]
                public List<long?> BizUnitIdList { get; set; }

                /// <summary>
                /// <para>The IDs of the business units.</para>
                /// </summary>
                [NameInMap("BizUnitNameList")]
                [Validation(Required=false)]
                public List<string> BizUnitNameList { get; set; }

                /// <summary>
                /// <para>The IDs of the data domains.</para>
                /// </summary>
                [NameInMap("DataDomainIdList")]
                [Validation(Required=false)]
                public List<long?> DataDomainIdList { get; set; }

                /// <summary>
                /// <para>The IDs of the data domains.</para>
                /// </summary>
                [NameInMap("DataDomainNameList")]
                [Validation(Required=false)]
                public List<string> DataDomainNameList { get; set; }

                /// <summary>
                /// <para>Specifies whether the business entity is associated with a logical table.</para>
                /// </summary>
                [NameInMap("HasTableRef")]
                [Validation(Required=false)]
                public bool? HasTableRef { get; set; }

                /// <summary>
                /// <para>The IDs of the owners.</para>
                /// </summary>
                [NameInMap("OwnerUserIdList")]
                [Validation(Required=false)]
                public List<string> OwnerUserIdList { get; set; }

                /// <summary>
                /// <para>The status of the business entity. For more information, refer to the &quot;Get business entity details&quot; API operation.</para>
                /// </summary>
                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public List<string> StatusList { get; set; }

                /// <summary>
                /// <para>The subtypes of the business entity. For more information, refer to the &quot;Get business entity details&quot; API operation.</para>
                /// </summary>
                [NameInMap("SubTypeList")]
                [Validation(Required=false)]
                public List<string> SubTypeList { get; set; }

            }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>object_</para>
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
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
