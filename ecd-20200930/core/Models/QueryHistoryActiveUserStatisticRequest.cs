// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryActiveUserStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The business channel type code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The end date of the query. The date is in the yyyy-MM-dd format. The maximum value is yesterday (N-1 data).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-31</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The workspace ID. If specified, only active users within the specified workspace are counted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-467671****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The start date of the query. The date is in the yyyy-MM-dd format. The value cannot be earlier than 6 months ago or later than EndDate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The user group ID. If specified, only active users within the specified user group are counted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-12345678</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
