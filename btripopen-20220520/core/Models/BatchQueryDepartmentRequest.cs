// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchQueryDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>The incremental filter for the department update time. If specified, only departments with gmt_modified &gt;= this time are returned. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-02 00:00:00</para>
        /// </summary>
        [NameInMap("modified_time_greater_or_equal_than")]
        [Validation(Required=false)]
        public string ModifiedTimeGreaterOrEqualThan { get; set; }

        /// <summary>
        /// <para>The third-party department ID. If this parameter is not empty, a single query is performed based on this ID, and pagination and time parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>129</para>
        /// </summary>
        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

        /// <summary>
        /// <para>The page size. Minimum value: 1. Maximum value: 1000. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token (opaque cursor). Do not pass this parameter for the first page. For subsequent pages, pass the next_cursor_token returned from the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9YN+jxa7PcxbNUTISeKjEw==</para>
        /// </summary>
        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
