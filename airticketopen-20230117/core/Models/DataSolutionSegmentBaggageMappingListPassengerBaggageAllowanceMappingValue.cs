// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class DataSolutionSegmentBaggageMappingListPassengerBaggageAllowanceMappingValue : TeaModel {
        /// <summary>
        /// <para>checked baggage quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("baggage_amount")]
        [Validation(Required=false)]
        public int? BaggageAmount { get; set; }

        /// <summary>
        /// <para>checked baggage weight</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public int? BaggageWeight { get; set; }

        /// <summary>
        /// <para>checked baggage weight unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("baggage_weight_unit")]
        [Validation(Required=false)]
        public string BaggageWeightUnit { get; set; }

        /// <summary>
        /// <para>Whether the weight is for all baggages</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_all_weight")]
        [Validation(Required=false)]
        public bool? IsAllWeight { get; set; }

        /// <summary>
        /// <para>carry-on baggage quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("carry_on_amount")]
        [Validation(Required=false)]
        public int? CarryOnAmount { get; set; }

        /// <summary>
        /// <para>carry-on baggage weight</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("carry_on_weight")]
        [Validation(Required=false)]
        public int? CarryOnWeight { get; set; }

        /// <summary>
        /// <para>carry-on baggage weight unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("carry_on_weight_unit")]
        [Validation(Required=false)]
        public string CarryOnWeightUnit { get; set; }

        /// <summary>
        /// <para>Whether the weight is for all baggages</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_all_carry_on_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryOnWeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("carry_length")]
        [Validation(Required=false)]
        public int? CarryLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("carry_width")]
        [Validation(Required=false)]
        public int? CarryWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("carry_height")]
        [Validation(Required=false)]
        public int? CarryHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>115</para>
        /// </summary>
        [NameInMap("carry_sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? CarrySumOfLengthWidthHeight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? SumOfLengthWidthHeight { get; set; }

    }

}
