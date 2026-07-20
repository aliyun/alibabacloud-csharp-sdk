// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleReShopItemListSubItemsBaggageRuleOfferBaggageInfoMapValue : TeaModel {
        /// <summary>
        /// <para>The departure city code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("start_city_code")]
        [Validation(Required=false)]
        public string StartCityCode { get; set; }

        /// <summary>
        /// <para>The arrival city code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("end_city_code")]
        [Validation(Required=false)]
        public string EndCityCode { get; set; }

        /// <summary>
        /// <para>The number of carry-on baggage pieces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("carry_free_pc")]
        [Validation(Required=false)]
        public int? CarryFreePc { get; set; }

        /// <summary>
        /// <para>The carry-on baggage weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("carry_bag_weight")]
        [Validation(Required=false)]
        public int? CarryBagWeight { get; set; }

        /// <summary>
        /// <para>The weight unit of carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KG</para>
        /// </summary>
        [NameInMap("carry_on_weight_unit")]
        [Validation(Required=false)]
        public string CarryOnWeightUnit { get; set; }

        /// <summary>
        /// <para>The carry-on baggage size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20<em>40</em>55CM、三边之和不超过115CM</para>
        /// </summary>
        [NameInMap("carry_bag_size")]
        [Validation(Required=false)]
        public string CarryBagSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the carry-on baggage weight represents the total weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_all_carry_bag_weight")]
        [Validation(Required=false)]
        public bool? IsAllCarryBagWeight { get; set; }

        /// <summary>
        /// <para>The total number of carry-on and checked baggage pieces. This field is for domestic flights only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total_pcs")]
        [Validation(Required=false)]
        public long? TotalPcs { get; set; }

        /// <summary>
        /// <para>The total weight of carry-on and checked baggage. This field is for domestic flights only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("total_weight")]
        [Validation(Required=false)]
        public long? TotalWeight { get; set; }

        /// <summary>
        /// <para>The unknown flag for carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("carry_unknown")]
        [Validation(Required=false)]
        public bool? CarryUnknown { get; set; }

        /// <summary>
        /// <para>The length of carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("carry_length")]
        [Validation(Required=false)]
        public int? CarryLength { get; set; }

        /// <summary>
        /// <para>The width of carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("carry_width")]
        [Validation(Required=false)]
        public int? CarryWidth { get; set; }

        /// <summary>
        /// <para>The height of carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("carry_height")]
        [Validation(Required=false)]
        public int? CarryHeight { get; set; }

        /// <summary>
        /// <para>The sum of length, width, and height of carry-on baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115</para>
        /// </summary>
        [NameInMap("carry_sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? CarrySumOfLengthWidthHeight { get; set; }

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
        /// <para>The maximum weight of checked baggage, in pounds or kilograms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("baggage_weight")]
        [Validation(Required=false)]
        public long? BaggageWeight { get; set; }

        /// <summary>
        /// <para>The weight unit of checked baggage.</para>
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
        /// <para>长宽高之和≤158CM</para>
        /// </summary>
        [NameInMap("baggage_size")]
        [Validation(Required=false)]
        public string BaggageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the checked baggage weight represents the total weight of all pieces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_weight")]
        [Validation(Required=false)]
        public bool? AllWeight { get; set; }

        /// <summary>
        /// <para>The length of checked baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The width of checked baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <para>The height of checked baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The sum of length, width, and height of checked baggage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115</para>
        /// </summary>
        [NameInMap("sum_of_length_width_height")]
        [Validation(Required=false)]
        public int? SumOfLengthWidthHeight { get; set; }

        /// <summary>
        /// <para>The unknown baggage flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("unknown")]
        [Validation(Required=false)]
        public bool? Unknown { get; set; }

        /// <summary>
        /// <para>The Chinese description of the baggage allowance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行李额中文描述</para>
        /// </summary>
        [NameInMap("cn_desc")]
        [Validation(Required=false)]
        public string CnDesc { get; set; }

        /// <summary>
        /// <para>The English description of the baggage allowance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行李额英文描述</para>
        /// </summary>
        [NameInMap("en_desc")]
        [Validation(Required=false)]
        public string EnDesc { get; set; }

        /// <summary>
        /// <para>The extended attributes in JSON format. For domestic flights, this field stores multiple text fields with the following field names:</para>
        /// <list type="bullet">
        /// <item><description>label: label</description></item>
        /// <item><description>excessInstruction: excess baggage instructions</description></item>
        /// <item><description>babyCar: baby stroller instructions</description></item>
        /// <item><description>phoneText: SMS text</description></item>
        /// <item><description>defaultRule: fallback rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;defaultRule&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// <para>The baggage price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("baggage_price")]
        [Validation(Required=false)]
        public int? BaggagePrice { get; set; }

        /// <summary>
        /// <para>The carry-on baggage tips.</para>
        /// 
        /// <b>Example:</b>
        /// <para>随身行李提示信息</para>
        /// </summary>
        [NameInMap("carry_on_baggage_tips")]
        [Validation(Required=false)]
        public string CarryOnBaggageTips { get; set; }

    }

}
