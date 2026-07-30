// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderListQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of business travel approval IDs.</para>
        /// </summary>
        [NameInMap("apply_id_list")]
        [Validation(Required=false)]
        public string ApplyIdListShrink { get; set; }

        /// <summary>
        /// <para>The list of order booking types.</para>
        /// </summary>
        [NameInMap("book_type_list")]
        [Validation(Required=false)]
        public string BookTypeListShrink { get; set; }

        /// <summary>
        /// <para>The list of booker IDs.</para>
        /// </summary>
        [NameInMap("booker_id")]
        [Validation(Required=false)]
        public string BookerIdShrink { get; set; }

        /// <summary>
        /// <para>The end date for the order query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
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
        [NameInMap("page_size")]
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
        /// <para>The start date for the order query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("start_date")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The list of third-party travel approval IDs.</para>
        /// </summary>
        [NameInMap("third_part_apply_id_list")]
        [Validation(Required=false)]
        public string ThirdPartApplyIdListShrink { get; set; }

    }

}
