// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListOperationRecordRequest : TeaModel {
        /// <summary>
        /// <para>The query command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListCommand")]
        [Validation(Required=false)]
        public ListOperationRecordRequestListCommand ListCommand { get; set; }
        public class ListOperationRecordRequestListCommand : TeaModel {
            /// <summary>
            /// <para>The end of the start time range. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-31 23:59:59</para>
            /// </summary>
            [NameInMap("BeginTimeEnd")]
            [Validation(Required=false)]
            public string BeginTimeEnd { get; set; }

            /// <summary>
            /// <para>The beginning of the start time range. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("BeginTimeStart")]
            [Validation(Required=false)]
            public string BeginTimeStart { get; set; }

            /// <summary>
            /// <para>The keyword for code search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("CodeContent")]
            [Validation(Required=false)]
            public string CodeContent { get; set; }

            /// <summary>
            /// <para>The list of code types.</para>
            /// </summary>
            [NameInMap("CodeType")]
            [Validation(Required=false)]
            public List<int?> CodeType { get; set; }

            /// <summary>
            /// <para>The list of duration ranges.</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public List<int?> Duration { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试脚本</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The list of object types.</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public List<string> ObjectType { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The sort type. Valid values: 0 (start time ascending), 1 (start time descending), 2 (object name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SortType")]
            [Validation(Required=false)]
            public int? SortType { get; set; }

            /// <summary>
            /// <para>The list of task statuses.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public List<int?> Status { get; set; }

            /// <summary>
            /// <para>The list of executor IDs.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

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

    }

}
