// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>175634</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CS-FLIGHT</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_end_time")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_start_time")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
