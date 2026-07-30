// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyQueryRequest : TeaModel {
        /// <summary>
        /// <para>The end time for filtering approval orders by creation time (less than). The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-18 20:26:56</para>
        /// </summary>
        [NameInMap("created_end_at")]
        [Validation(Required=false)]
        public string CreatedEndAt { get; set; }

        /// <summary>
        /// <para>The start time for filtering approval orders by creation time (greater than or equal to). The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-18 20:26:56</para>
        /// </summary>
        [NameInMap("created_start_at")]
        [Validation(Required=false)]
        public string CreatedStartAt { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than or equal to 1. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The third-party approval order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apply1</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The third-party employee ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userid</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
