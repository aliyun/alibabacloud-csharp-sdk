// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSubmitRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListSubmitRecordsRequestListQuery ListQuery { get; set; }
        public class ListSubmitRecordsRequestListQuery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SearchFilter")]
            [Validation(Required=false)]
            public ListSubmitRecordsRequestListQuerySearchFilter SearchFilter { get; set; }
            public class ListSubmitRecordsRequestListQuerySearchFilter : TeaModel {
                [NameInMap("ChangeTypeList")]
                [Validation(Required=false)]
                public List<int?> ChangeTypeList { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ProjectIdList")]
                [Validation(Required=false)]
                public List<long?> ProjectIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("SubmitEndTime")]
                [Validation(Required=false)]
                public string SubmitEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("SubmitStartTime")]
                [Validation(Required=false)]
                public string SubmitStartTime { get; set; }

                [NameInMap("SubmitterList")]
                [Validation(Required=false)]
                public List<string> SubmitterList { get; set; }

            }

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
