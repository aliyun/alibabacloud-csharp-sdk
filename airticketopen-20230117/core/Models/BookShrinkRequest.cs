// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The contact information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        /// <summary>
        /// <para>The external order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x091-2023-0220-j-0001</para>
        /// </summary>
        [NameInMap("out_order_num")]
        [Validation(Required=false)]
        public string OutOrderNum { get; set; }

        /// <summary>
        /// <para>The mapping between passengers and ancillary purchases.</para>
        /// </summary>
        [NameInMap("passenger_ancillary_purchase_map_list")]
        [Validation(Required=false)]
        public string PassengerAncillaryPurchaseMapListShrink { get; set; }

        /// <summary>
        /// <para>The list of passengers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public string PassengerListShrink { get; set; }

        /// <summary>
        /// <para>solution_id.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
