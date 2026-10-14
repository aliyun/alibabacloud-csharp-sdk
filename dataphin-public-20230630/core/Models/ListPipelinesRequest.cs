// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The request context.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public ListPipelinesRequestContext Context { get; set; }
        public class ListPipelinesRequestContext : TeaModel {
            /// <summary>
            /// <para>The environment identifier. Valid values: DEV: development environment. PROD: production environment. Default value: PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7128268454335680</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListCommand")]
        [Validation(Required=false)]
        public ListPipelinesRequestListCommand ListCommand { get; set; }
        public class ListPipelinesRequestListCommand : TeaModel {
            /// <summary>
            /// <para>The user IDs of the creators used for filtering. If this parameter is left empty, no filtering is performed. If multiple IDs are specified, they are evaluated by using the OR operator.</para>
            /// </summary>
            [NameInMap("CreatorList")]
            [Validation(Required=false)]
            public List<string> CreatorList { get; set; }

            /// <summary>
            /// <para>The user IDs of the development owners used for filtering. If this parameter is left empty, no filtering is performed. If multiple IDs are specified, they are evaluated by using the OR operator.</para>
            /// </summary>
            [NameInMap("DevelopOwnerList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerList { get; set; }

            /// <summary>
            /// <para>The full paths of the directories to query. If this parameter is left empty, the root directory is queried.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            /// <summary>
            /// <para>Specifies whether an exact match is performed on the node name. Default value: false.</para>
            /// </summary>
            [NameInMap("ExactMatch")]
            [Validation(Required=false)]
            public bool? ExactMatch { get; set; }

            /// <summary>
            /// <para>The keywords used to filter task names. This parameter is optional. If this parameter is left empty, tasks are not filtered by name. If exact match is enabled, this parameter specifies a list of full names. If fuzzy match is used, this parameter specifies a list of keywords. If multiple keywords are specified, they are evaluated by using the OR operator.</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The cursor for the next page. Leave this parameter empty for the first page. For subsequent pages, pass the NextCursor value returned from the previous page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("NextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            /// <summary>
            /// <para>The user IDs of the O&amp;M owners used for filtering. If this parameter is left empty, no filtering is performed. If multiple IDs are specified, they are evaluated by using the OR operator.</para>
            /// </summary>
            [NameInMap("OpsOwnerList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerList { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1. The value starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The task types. Default value: [0]. Valid values: 0: offline integration. 1: real-time integration. 13: data ingestion. 14: offline unstructured workflow. 15: real-time unstructured workflow. 16: online unstructured workflow. If you pass null or an empty list, the default value [0] is used.</para>
            /// </summary>
            [NameInMap("PipelineTypeList")]
            [Validation(Required=false)]
            public List<int?> PipelineTypeList { get; set; }

            /// <summary>
            /// <para>Specifies whether to recursively query subdirectories. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Recursive")]
            [Validation(Required=false)]
            public bool? Recursive { get; set; }

            /// <summary>
            /// <para>The schedule types used for filtering. If this parameter is left empty, no filtering is performed. Valid values: 1: periodic scheduling. 3: manual scheduling. 5: real-time scheduling. 7: online workflow.</para>
            /// </summary>
            [NameInMap("ScheduleTypeList")]
            [Validation(Required=false)]
            public List<int?> ScheduleTypeList { get; set; }

            /// <summary>
            /// <para>The submit statuses used for filtering. If this parameter is left empty, no filtering is performed. Valid values: DRAFT: draft. SUBMITTING: submitting. SUBMITTED: submitted. PUBLISHED: published.</para>
            /// </summary>
            [NameInMap("SubmitStatusList")]
            [Validation(Required=false)]
            public List<string> SubmitStatusList { get; set; }

            /// <summary>
            /// <para>The tag names used for filtering. If this parameter is left empty, no filtering is performed. If multiple names are specified, they are evaluated by using the OR operator.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
