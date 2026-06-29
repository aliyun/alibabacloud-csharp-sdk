// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPublishRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Query command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListPublishRecordsRequestListQuery ListQuery { get; set; }
        public class ListPublishRecordsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>Publish record filter.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SearchFilter")]
            [Validation(Required=false)]
            public ListPublishRecordsRequestListQuerySearchFilter SearchFilter { get; set; }
            public class ListPublishRecordsRequestListQuerySearchFilter : TeaModel {
                /// <summary>
                /// <para>List of change types (0: Create, 1: Update, 2: Delete).</para>
                /// </summary>
                [NameInMap("ChangeTypeList")]
                [Validation(Required=false)]
                public List<int?> ChangeTypeList { get; set; }

                /// <summary>
                /// <para>Page number.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                /// <summary>
                /// <para>Page size.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>List of project IDs.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ProjectIdList")]
                [Validation(Required=false)]
                public List<long?> ProjectIdList { get; set; }

                /// <summary>
                /// <para>Publish end time in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("PublishEndTime")]
                [Validation(Required=false)]
                public string PublishEndTime { get; set; }

                /// <summary>
                /// <para>Publish start time in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("PublishStartTime")]
                [Validation(Required=false)]
                public string PublishStartTime { get; set; }

                /// <summary>
                /// <para>List of publish statuses (0: Failed, 1: Succeeded, 2: Publishing).</para>
                /// </summary>
                [NameInMap("PublishStatusList")]
                [Validation(Required=false)]
                public List<int?> PublishStatusList { get; set; }

                /// <summary>
                /// <para>List of submitter IDs.</para>
                /// </summary>
                [NameInMap("SubmitterList")]
                [Validation(Required=false)]
                public List<string> SubmitterList { get; set; }

            }

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
