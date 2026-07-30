// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemSubItemsBaggageRuleBaggageInfoMapValue : TeaModel {
        /// <summary>
        /// <para>The number of carry-on baggage pieces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("carry_freepc")]
        [Validation(Required=false)]
        public int? CarryFreepc { get; set; }

        /// <summary>
        /// <para>The carry-on baggage weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("carry_bag_weight")]
        [Validation(Required=false)]
        public int? CarryBagWeight { get; set; }

        /// <summary>
        /// <para>The carry-on baggage size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20*20</para>
        /// </summary>
        [NameInMap("carry_bag_size")]
        [Validation(Required=false)]
        public string CarryBagSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the carry-on baggage weight is the total weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_all_carry_bag_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryBagWeight { get; set; }

        /// <summary>
        /// <para>The airline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA</para>
        /// </summary>
        [NameInMap("airline")]
        [Validation(Required=false)]
        public string Airline { get; set; }

        /// <summary>
        /// <para>The departure airport three-letter code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("start_airport")]
        [Validation(Required=false)]
        public string StartAirport { get; set; }

        /// <summary>
        /// <para>The arrival airport three-letter code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("end_airport")]
        [Validation(Required=false)]
        public string EndAirport { get; set; }

        /// <summary>
        /// <para>The departure city three-letter code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("start_city_code")]
        [Validation(Required=false)]
        public string StartCityCode { get; set; }

        /// <summary>
        /// <para>The arrival city three-letter code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("end_city_code")]
        [Validation(Required=false)]
        public string EndCityCode { get; set; }

        /// <summary>
        /// <para>The number of checked baggage pieces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("free_pcs")]
        [Validation(Required=false)]
        public long? FreePcs { get; set; }

        /// <summary>
        /// <para>The maximum checked baggage weight in pounds and kilograms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public long? BaggageWeight { get; set; }

        /// <summary>
        /// <para>The weight unit for checked baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("baggage_unit")]
        [Validation(Required=false)]
        public string BaggageUnit { get; set; }

        /// <summary>
        /// <para>The checked baggage size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40*50</para>
        /// </summary>
        [NameInMap("baggage_size")]
        [Validation(Required=false)]
        public string BaggageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the checked baggage weight is the total weight of all pieces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all_weight")]
        [Validation(Required=false)]
        public bool? AllWeight { get; set; }

    }

}
