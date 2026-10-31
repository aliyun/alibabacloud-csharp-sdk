// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListStandardsRequestListQuery ListQuery { get; set; }
        public class ListStandardsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The folder to which the standard belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dir1/dir2</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The search keyword. Supports case-insensitive fuzzy search by standard name, English name, or code, and sorts results by relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
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
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The IDs of the standard sets to which the standards belong.</para>
            /// </summary>
            [NameInMap("StandardSetIdList")]
            [Validation(Required=false)]
            public List<long?> StandardSetIdList { get; set; }

            /// <summary>
            /// <para>The stages of the standards. Valid values: DEV and PROD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("StandardStage")]
            [Validation(Required=false)]
            public string StandardStage { get; set; }

            /// <summary>
            /// <para>The list of standard statuses. For the DEV stage, the standard statuses are: DRAFT (Draft), UNDER_REVISION (Under Revision), UNDER_REVIEW (Under Review), REVIEW_PASSED (Approved), and IN_PUBLISH (Publishing). For the PROD stage, the standard statuses are: NOT_ACTIVATED (Not Activated), ACTIVE (Active), and EXPIRED (Expired).</para>
            /// </summary>
            [NameInMap("StandardStatusList")]
            [Validation(Required=false)]
            public List<string> StandardStatusList { get; set; }

            /// <summary>
            /// <para>The IDs of the standard templates to which the standards belong.</para>
            /// </summary>
            [NameInMap("StandardTemplateIdList")]
            [Validation(Required=false)]
            public List<long?> StandardTemplateIdList { get; set; }

            /// <summary>
            /// <para>The list of standard types. Valid values: Basic, and EMPTY (the standard type is empty).</para>
            /// </summary>
            [NameInMap("StandardTypeList")]
            [Validation(Required=false)]
            public List<string> StandardTypeList { get; set; }

            /// <summary>
            /// <para>The user ID. If specified, only standards visible to this user are queried. If left empty, standards visible to the current user are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
