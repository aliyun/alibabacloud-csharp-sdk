// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ElectronicItineraryBatchApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_itinerary_list")]
        [Validation(Required=false)]
        public List<ElectronicItineraryBatchApplyRequestApplyItineraryList> ApplyItineraryList { get; set; }
        public class ElectronicItineraryBatchApplyRequestApplyItineraryList : TeaModel {
            [NameInMap("purchaser_name")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tax3213132131</para>
            /// </summary>
            [NameInMap("purchaser_tax_no")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("purchaser_type")]
            [Validation(Required=false)]
            public int? PurchaserType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>781-2205431917</para>
            /// </summary>
            [NameInMap("ticket_no")]
            [Validation(Required=false)]
            public string TicketNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("can_reprint")]
        [Validation(Required=false)]
        public bool? CanReprint { get; set; }

    }

}
