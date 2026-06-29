// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsRequest : TeaModel {
        /// <summary>
        /// <para>Search conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListStandardsRequestListQuery ListQuery { get; set; }
        public class ListStandardsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Directory of the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dir1/dir2</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>Search keyword: fuzzy search by standard name, English name, or code. Case-insensitive, sorted by relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>Page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>Number of records per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Standard set ID list.</para>
            /// </summary>
            [NameInMap("StandardSetIdList")]
            [Validation(Required=false)]
            public List<long?> StandardSetIdList { get; set; }

            /// <summary>
            /// <para>Stage of the standard: DEV or PROD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("StandardStage")]
            [Validation(Required=false)]
            public string StandardStage { get; set; }

            /// <summary>
            /// <para>Standard status list. Standard statuses under DEV stage: DRAFT, UNDER_REVISION, UNDER_REVIEW, REVIEW_PASSED, IN_PUBLISH. Standard statuses under PROD stage: NOT_ACTIVATED, ACTIVE, EXPIRED.</para>
            /// </summary>
            [NameInMap("StandardStatusList")]
            [Validation(Required=false)]
            public List<string> StandardStatusList { get; set; }

            /// <summary>
            /// <para>Standard template ID list.</para>
            /// </summary>
            [NameInMap("StandardTemplateIdList")]
            [Validation(Required=false)]
            public List<long?> StandardTemplateIdList { get; set; }

            /// <summary>
            /// <para>Standard type: Basic, EMPTY indicates the standard type is empty.</para>
            /// </summary>
            [NameInMap("StandardTypeList")]
            [Validation(Required=false)]
            public List<string> StandardTypeList { get; set; }

            /// <summary>
            /// <para>User ID: only queries standards visible to this user ID. If empty, queries standards visible to the current user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID.</para>
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
