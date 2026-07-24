// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AccountFlowListRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to search. Maximum value: 30. Valid values: 0 to 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("day_num")]
        [Validation(Required=false)]
        public int? DayNum { get; set; }

        /// <summary>
        /// <para>The page index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start search timestamp, effective to the day. Specify a 13-digit UTC timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677427200000</para>
        /// </summary>
        [NameInMap("utc_begin_time")]
        [Validation(Required=false)]
        public long? UtcBeginTime { get; set; }

    }

}
