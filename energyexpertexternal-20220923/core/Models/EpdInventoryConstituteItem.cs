// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class EpdInventoryConstituteItem : TeaModel {
        /// <summary>
        /// <para>Emissions are presented with 24 decimal places. It\&quot;s advisable to utilize the truncated version. These emissions encompass all tiers: At the first level, they reflect the product\&quot;s total emissions under the current environmental impact; at the second level, they show the process\&quot;s total emissions; and at the third level, they represent the inventory\&quot;s emissions within the same environmental impact context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1009.976265540000000000000000000000</para>
        /// </summary>
        [NameInMap("carbonEmission")]
        [Validation(Required=false)]
        public double? CarbonEmission { get; set; }

        /// <summary>
        /// <para>The value of the factor. Only the third level is not empty. The factor in the inventory information indicates the factor value of the selected factor. The factor value is kept to four decimal places after the decimal point, and &quot;1.0000&quot; indicates that the factor value is 1. The factor value should be used in combination with factorUnit. If factorUnit is &quot;kg CO2-Eq mg/kg&quot;, it means that the carbon emission per 1kg of the list is 1kg CO2-Eq.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0000</para>
        /// </summary>
        [NameInMap("factor")]
        [Validation(Required=false)]
        public string Factor { get; set; }

        /// <summary>
        /// <para>The database to which the factorDataset factor belongs. This field is used in conjunction with factorType. If factorType is 1, the data name of the factor is displayed. If factorType is 2,factorId indicates the ID of the referenced product. If factorType is null,factorId is meaningless. This field is a new field. Old data may not have data in this field and is displayed as &quot;/&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("factorDataset")]
        [Validation(Required=false)]
        public string FactorDataset { get; set; }

        /// <summary>
        /// <para>The id of the factor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("factorId")]
        [Validation(Required=false)]
        public string FactorId { get; set; }

        /// <summary>
        /// <para>The key of the factor type. Only the third level is not empty. The factorType in the inventory information indicates that the factor source type is selected; the optional values are 1, 2, or null:1: factor library, 2: product library. null indicates that the factor is not selected from the factor library or product library, and the factor is constructed by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("factorType")]
        [Validation(Required=false)]
        public int? FactorType { get; set; }

        /// <summary>
        /// <para>Factor Unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>kg CO2-Eq/kg</para>
        /// </summary>
        [NameInMap("factorUnit")]
        [Validation(Required=false)]
        public string FactorUnit { get; set; }

        /// <summary>
        /// <para>manifest id</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("inventoryId")]
        [Validation(Required=false)]
        public long? InventoryId { get; set; }

        /// <summary>
        /// <para>Inventory Unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>t</para>
        /// </summary>
        [NameInMap("inventoryUnit")]
        [Validation(Required=false)]
        public string InventoryUnit { get; set; }

        /// <summary>
        /// <para>The quantity of the inventory. It is not empty only at the third level. The third level is the inventory details. This field indicates the id of the inventory. It should be used in conjunction with the InventoryUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.000000000000000000000000</para>
        /// </summary>
        [NameInMap("inventoryValue")]
        [Validation(Required=false)]
        public double? InventoryValue { get; set; }

        /// <summary>
        /// <para>Activity data per functional unit: only the third level is not empty; the value retains 24 decimal places, indicating the number of activities per functional unit; should be used in conjunction with the inventoryValuePerProductUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.000000000000000000000000</para>
        /// </summary>
        [NameInMap("inventoryValuePerProduct")]
        [Validation(Required=false)]
        public double? InventoryValuePerProduct { get; set; }

        /// <summary>
        /// <para>Unit of activity data per functional unit. Only the third level is not empty. in the inventory information indicates the unit of activity data per functional unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kg</para>
        /// </summary>
        [NameInMap("inventoryValuePerProductUnit")]
        [Validation(Required=false)]
        public string InventoryValuePerProductUnit { get; set; }

        /// <summary>
        /// <para>List of children</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<EpdInventoryConstituteItem> Items { get; set; }

        /// <summary>
        /// <para>Returns the name of the current level. The names of different levels have different meanings. The first level returns the environmental impact type. The second level returns the current process name. The third level returns the current inventory name</para>
        /// 
        /// <b>Example:</b>
        /// <para>climate change</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Category key, please refer to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        /// <summary>
        /// <para>The percentage. Four decimal places are retained and 31.4000 is returned to indicate the percentage 31.4%. The first level returns null; The second level returns the current process as a percentage of total emissions; the third level returns the current inventory as a percentage of total emissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31.4000</para>
        /// </summary>
        [NameInMap("percent")]
        [Validation(Required=false)]
        public double? Percent { get; set; }

        /// <summary>
        /// <para>Raw activity data. Only the third level returns a quantity that is not null, indicating a manifest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.000000000000</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// <para>The type of the inventory. Only the third level returns non-null, and the third level is the inventory details. This field indicates the resource type name of the inventory. You may refer to <a href="https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf">Carbon Footprint Appendices</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Energy</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The data status. 1 indicates accurate calculation, 2 indicates default data, 3 indicates missing factor, and 0 value is used in other cases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The unit of environmental impact result value. This unit is the unit of the environmental impact result value of the corresponding environmental impact category. For example, the unit kg CO2-Eq represent the emission values shown here is kg CO2-Eq.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kg CO2-Eq</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
