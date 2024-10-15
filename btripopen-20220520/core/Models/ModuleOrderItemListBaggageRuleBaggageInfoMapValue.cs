// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleOrderItemListBaggageRuleBaggageInfoMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("carry_freepc")]
        [Validation(Required=false)]
        public int? CarryFreepc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("carry_bag_weight")]
        [Validation(Required=false)]
        public int? CarryBagWeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("carry_bag_size")]
        [Validation(Required=false)]
        public string CarryBagSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_all_carry_bag_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryBagWeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CZ</para>
        /// </summary>
        [NameInMap("airline")]
        [Validation(Required=false)]
        public string Airline { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PKX</para>
        /// </summary>
        [NameInMap("start_airport")]
        [Validation(Required=false)]
        public string StartAirport { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAN</para>
        /// </summary>
        [NameInMap("end_airport")]
        [Validation(Required=false)]
        public string EndAirport { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("start_city_code")]
        [Validation(Required=false)]
        public string StartCityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAN</para>
        /// </summary>
        [NameInMap("end_city_code")]
        [Validation(Required=false)]
        public string EndCityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("free_pcs")]
        [Validation(Required=false)]
        public long? FreePcs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public long? BaggageWeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kg</para>
        /// </summary>
        [NameInMap("baggage_unit")]
        [Validation(Required=false)]
        public string BaggageUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("baggage_size")]
        [Validation(Required=false)]
        public string BaggageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all_weight")]
        [Validation(Required=false)]
        public bool? AllWeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total_pcs")]
        [Validation(Required=false)]
        public long? TotalPcs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total_weight")]
        [Validation(Required=false)]
        public long? TotalWeight { get; set; }

    }

}
