// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListItemListShoppingItemMapValueCabinQuantityValue : TeaModel {
        /// <summary>
        /// <para>The cabin code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R</para>
        /// </summary>
        [NameInMap("cabin")]
        [Validation(Required=false)]
        public string Cabin { get; set; }

        /// <summary>
        /// <para>The cabin class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        /// <summary>
        /// <para>The cabin class name. Displays the custom name if available, otherwise displays the generic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>经济舱</para>
        /// </summary>
        [NameInMap("cabin_class_name")]
        [Validation(Required=false)]
        public string CabinClassName { get; set; }

        /// <summary>
        /// <para>The cabin class description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>舱位等级描述</para>
        /// </summary>
        [NameInMap("cabin_class_memo")]
        [Validation(Required=false)]
        public string CabinClassMemo { get; set; }

        /// <summary>
        /// <para>The domestic special notes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>国内特殊说明</para>
        /// </summary>
        [NameInMap("specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The number of remaining seats in the cabin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public string Quantity { get; set; }

        /// <summary>
        /// <para>The linked cabins, used for industry seat verification.</para>
        /// </summary>
        [NameInMap("link_cabins")]
        [Validation(Required=false)]
        public List<string> LinkCabins { get; set; }

        /// <summary>
        /// <para>The cabin class change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reshop_change_cabin")]
        [Validation(Required=false)]
        public bool? ReshopChangeCabin { get; set; }

        /// <summary>
        /// <para>The child cabin type. Refer to: com.taobao.trip.gds.common.enumerate.GdsChildTicketType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>儿童舱位类型</para>
        /// </summary>
        [NameInMap("child_cabin_type")]
        [Validation(Required=false)]
        public int? ChildCabinType { get; set; }

        /// <summary>
        /// <para>The infant base cabin. This is the base cabin corresponding to the cabin class of the adult cabin information, used to retrieve fare data for infant pricing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>婴儿基准舱位</para>
        /// </summary>
        [NameInMap("infant_basic_cabin")]
        [Validation(Required=false)]
        public string InfantBasicCabin { get; set; }

        /// <summary>
        /// <para>The sub-cabin type, used for domestic flights. Refer to InnerCabinClass[FIRST,BUSINESS,ECONOMY,PREMIUM_ECONOMY,PREMIUM_FIRST,code,text,flag].</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("inner_cabin_class")]
        [Validation(Required=false)]
        public int? InnerCabinClass { get; set; }

    }

}
