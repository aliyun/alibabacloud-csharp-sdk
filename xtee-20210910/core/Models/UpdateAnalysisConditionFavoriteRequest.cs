// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UpdateAnalysisConditionFavoriteRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The condition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;relationship\&quot;:\&quot;and\&quot;,\&quot;list\&quot;:[{\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;hasRightVariable\&quot;:true,\&quot;fieldType\&quot;:\&quot;INT\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;leftVariableType\&quot;:\&quot;NATIVE\&quot;,\&quot;name\&quot;:\&quot;DEtest222\&quot;,\&quot;operatorCode\&quot;:\&quot;equals\&quot;},\&quot;right\&quot;:{\&quot;rightVariableType\&quot;:\&quot;constant\&quot;,\&quot;name\&quot;:\&quot;9007199254\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;},\&quot;operatorCode\&quot;:\&quot;equals\&quot;}]}</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The start time, in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752076800000</para>
        /// </summary>
        [NameInMap("eventBeginTime")]
        [Validation(Required=false)]
        public long? EventBeginTime { get; set; }

        /// <summary>
        /// <para>The event code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ajnoqe2016</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>The end time, in milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753891199000</para>
        /// </summary>
        [NameInMap("eventEndTime")]
        [Validation(Required=false)]
        public long? EventEndTime { get; set; }

        /// <summary>
        /// <para>The field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>age</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The field value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("fieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The primary key ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3144</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The condition name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询条件1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BASIC: basic query.</description></item>
        /// <item><description>ADVANCE: advanced query.</description></item>
        /// <item><description>BATCH: batch query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
