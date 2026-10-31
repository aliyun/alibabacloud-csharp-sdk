// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListRectifyFlowRequest : TeaModel {
        /// <summary>
        /// <para>The business request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListRectifyFlowRequestListQuery ListQuery { get; set; }
        public class ListRectifyFlowRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The governance object type. Valid values: TABLE, DATASOURCE_TABLE, DATASOURCE, INDEX, REALTIME_LOGICAL_TABLE, and QD_FEATURE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("GovernItemType")]
            [Validation(Required=false)]
            public string GovernItemType { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7381905</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8322096</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The priority filters. Valid values: HIGH, MIDDLE, and LOW.</para>
            /// </summary>
            [NameInMap("PriorityFilters")]
            [Validation(Required=false)]
            public List<string> PriorityFilters { get; set; }

            /// <summary>
            /// <para>The list of rectifier IDs.</para>
            /// </summary>
            [NameInMap("RectifyUserFilters")]
            [Validation(Required=false)]
            public List<string> RectifyUserFilters { get; set; }

            /// <summary>
            /// <para>SUBMIT_RECTIFY, SUBMIT_VERIFY, FINISH_VERIFY, and REJECT_VERIFY.</para>
            /// </summary>
            [NameInMap("StatusFilters")]
            [Validation(Required=false)]
            public List<string> StatusFilters { get; set; }

            /// <summary>
            /// <para>The list of verifier IDs.</para>
            /// </summary>
            [NameInMap("VerifyUserFilters")]
            [Validation(Required=false)]
            public List<string> VerifyUserFilters { get; set; }

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
