// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryRequest : TeaModel {
        /// <summary>
        /// <para>The employee information update time.</para>
        /// <list type="bullet">
        /// <item><description>After you specify a time, the system queries employee information with an update time <b>greater than or equal to</b> the specified time.</description></item>
        /// <item><description>Use the <c>yyyy-MM-dd HH:mm:ss</c> string format when passing this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("modified_time_greater_or_equal_than")]
        [Validation(Required=false)]
        public string ModifiedTimeGreaterOrEqualThan { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 1. Maximum value: 1000.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the start position of the current page.</para>
        /// <list type="bullet">
        /// <item><description>Leave this empty when retrieving the first page.</description></item>
        /// <item><description>Pass the pagination token returned from the previous page when retrieving the next page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9YN+jx********ISeKjEw==</para>
        /// </summary>
        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <para>The employee job number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job_1234</para>
        /// </summary>
        [NameInMap("third_part_job_no")]
        [Validation(Required=false)]
        public string ThirdPartJobNo { get; set; }

    }

}
