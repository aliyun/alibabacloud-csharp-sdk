// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class FieldSpec : TeaModel {
        /// <summary>
        /// <para>Specifies whether the field can be analyzed, that is, whether it can be used as a dimension column in a GROUP BY clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("analysable")]
        [Validation(Required=false)]
        public bool? Analysable { get; set; }

        /// <summary>
        /// <para>The formatting method for numeric or display values, such as KMB (thousand/million/billion), percent, ms, or dthms (hours:minutes:seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMB</para>
        /// </summary>
        [NameInMap("data_format")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The business description of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The unique ID of the transaction order</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name used in the console. The value can contain Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OrderNumber</para>
        /// </summary>
        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the field can be filtered, that is, whether index-based filter queries are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("filterable")]
        [Validation(Required=false)]
        public bool? Filterable { get; set; }

        /// <summary>
        /// <para>The launch stage of the field. Valid values: preview, beta, ga, and deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga</para>
        /// </summary>
        [NameInMap("launch_stage")]
        [Validation(Required=false)]
        public string LaunchStage { get; set; }

        /// <summary>
        /// <para>The field name. The value must consist of lowercase letters, digits, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_id</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether the field can be sorted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("orderable")]
        [Validation(Required=false)]
        public bool? Orderable { get; set; }

        /// <summary>
        /// <para>The short description (one sentence) used in compact display scenarios such as lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order ID</para>
        /// </summary>
        [NameInMap("short_description")]
        [Validation(Required=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// <para>The field type. Valid values: string, integer, float, boolean, time, json_object, and json_array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The unit of the field. The unit is used only for display purposes and is not automatically converted. For example, ms is not automatically converted to s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <para>The value mapping for enumerated values. The key is the raw value and the value is the mapped semantic name. This is used to display the business meaning of enumerated values. For example, the value 1 of the status field is mapped to running.</para>
        /// </summary>
        [NameInMap("value_mapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> ValueMapping { get; set; }

    }

}
