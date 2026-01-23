// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityWatchTasksRequest : TeaModel {
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityWatchTasksRequestListQuery ListQuery { get; set; }
        public class ListQualityWatchTasksRequestListQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            [NameInMap("DataSourceIdList")]
            [Validation(Required=false)]
            public List<string> DataSourceIdList { get; set; }

            [NameInMap("DataSourceOwnerList")]
            [Validation(Required=false)]
            public List<string> DataSourceOwnerList { get; set; }

            [NameInMap("DataSourceScopeList")]
            [Validation(Required=false)]
            public List<string> DataSourceScopeList { get; set; }

            [NameInMap("DataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> DataSourceTypeList { get; set; }

            [NameInMap("ErrorRuleStrengthList")]
            [Validation(Required=false)]
            public List<string> ErrorRuleStrengthList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
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

            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            [NameInMap("QualityOwnerList")]
            [Validation(Required=false)]
            public List<string> QualityOwnerList { get; set; }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            [NameInMap("TableOwnerList")]
            [Validation(Required=false)]
            public List<string> TableOwnerList { get; set; }

            [NameInMap("TableTypeList")]
            [Validation(Required=false)]
            public List<string> TableTypeList { get; set; }

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
