// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2Request : TeaModel {
        /// <summary>
        /// <para>The list of business travel approval IDs.</para>
        /// </summary>
        [NameInMap("approve_id")]
        [Validation(Required=false)]
        public List<string> ApproveId { get; set; }

        /// <summary>
        /// <para>The list of booker IDs.</para>
        /// </summary>
        [NameInMap("booker_id")]
        [Validation(Required=false)]
        public List<string> BookerId { get; set; }

        /// <summary>
        /// <para>The list of booker department IDs.</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public List<string> DepartId { get; set; }

        /// <summary>
        /// <para>The end time of the order booking period.</para>
        /// <remarks>
        /// <para>Notice: The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_Size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scroll ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4ZGViODFlYmM3MYzM4</para>
        /// </summary>
        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>The start time of the order booking period.</para>
        /// <remarks>
        /// <para>Notice: The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("start_date")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The list of supplier names.</para>
        /// </summary>
        [NameInMap("supplier")]
        [Validation(Required=false)]
        public List<string> Supplier { get; set; }

        /// <summary>
        /// <para>The list of third-party approval IDs.</para>
        /// </summary>
        [NameInMap("thirdpart_approve_id")]
        [Validation(Required=false)]
        public List<string> ThirdpartApproveId { get; set; }

        /// <summary>
        /// <para>The end time of the order update period.</para>
        /// <remarks>
        /// <para>Notice: The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_end_date")]
        [Validation(Required=false)]
        public string UpdateEndDate { get; set; }

        /// <summary>
        /// <para>The start time of the order update period.</para>
        /// <remarks>
        /// <para>Notice: The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01 00:00:00</para>
        /// </summary>
        [NameInMap("update_start_date")]
        [Validation(Required=false)]
        public string UpdateStartDate { get; set; }

    }

}
