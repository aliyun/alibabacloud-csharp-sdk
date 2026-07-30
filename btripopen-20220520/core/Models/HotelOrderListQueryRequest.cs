// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderListQueryRequest : TeaModel {
        /// <summary>
        /// <para>false: searches for unreimbursed orders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        /// <summary>
        /// <para>The business travel approval ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165782</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>The category code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: domestic hotel.</description></item>
        /// <item><description>12: international or China Hong Kong, Macao, and Taiwan hotel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>The department ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户所在部门id</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <para>The end time. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The third-party application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS154JKOI</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The update end time. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_end_time")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        /// <summary>
        /// <para>The update start time. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_start_time")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        /// <summary>
        /// <para>The third-party user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第三方用户ID</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
