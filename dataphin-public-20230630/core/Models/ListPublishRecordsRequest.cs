// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPublishRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The query command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListPublishRecordsRequestListQuery ListQuery { get; set; }
        public class ListPublishRecordsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The publish record filter.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SearchFilter")]
            [Validation(Required=false)]
            public ListPublishRecordsRequestListQuerySearchFilter SearchFilter { get; set; }
            public class ListPublishRecordsRequestListQuerySearchFilter : TeaModel {
                /// <summary>
                /// <para>The list of change types (0: Create, 1: Update, 2: Delete).</para>
                /// </summary>
                [NameInMap("ChangeTypeList")]
                [Validation(Required=false)]
                public List<int?> ChangeTypeList { get; set; }

                /// <summary>
                /// <para>The page number.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The list of project IDs.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ProjectIdList")]
                [Validation(Required=false)]
                public List<long?> ProjectIdList { get; set; }

                /// <summary>
                /// <para>The publish end time in yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("PublishEndTime")]
                [Validation(Required=false)]
                public string PublishEndTime { get; set; }

                /// <summary>
                /// <para>The publish start time in yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("PublishStartTime")]
                [Validation(Required=false)]
                public string PublishStartTime { get; set; }

                /// <summary>
                /// <para>The list of publish statuses (0: Failed, 1: Successful, 2: Publishing).</para>
                /// </summary>
                [NameInMap("PublishStatusList")]
                [Validation(Required=false)]
                public List<int?> PublishStatusList { get; set; }

                /// <summary>
                /// <para>The list of submitter IDs.</para>
                /// </summary>
                [NameInMap("SubmitterList")]
                [Validation(Required=false)]
                public List<string> SubmitterList { get; set; }

            }

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
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
