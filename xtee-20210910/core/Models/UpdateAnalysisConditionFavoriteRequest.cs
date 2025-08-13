// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UpdateAnalysisConditionFavoriteRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Condition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;relationship\&quot;:\&quot;and\&quot;,\&quot;list\&quot;:[{\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;hasRightVariable\&quot;:true,\&quot;fieldType\&quot;:\&quot;INT\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;leftVariableType\&quot;:\&quot;NATIVE\&quot;,\&quot;name\&quot;:\&quot;DEtest222\&quot;,\&quot;operatorCode\&quot;:\&quot;equals\&quot;},\&quot;right\&quot;:{\&quot;rightVariableType\&quot;:\&quot;constant\&quot;,\&quot;name\&quot;:\&quot;9007199254\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;},\&quot;operatorCode\&quot;:\&quot;equals\&quot;}]}</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>Start time, accurate to milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752076800000</para>
        /// </summary>
        [NameInMap("eventBeginTime")]
        [Validation(Required=false)]
        public long? EventBeginTime { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ajnoqe2016</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>End time, accurate to milliseconds (ms).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753891199000</para>
        /// </summary>
        [NameInMap("eventEndTime")]
        [Validation(Required=false)]
        public long? EventEndTime { get; set; }

        /// <summary>
        /// <para>Field name</para>
        /// 
        /// <b>Example:</b>
        /// <para>age</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>Field value</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("fieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>Primary key ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3144</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Condition name</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询条件1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Type, BASIC: Basic query, ADVANCE: Advanced query, BATCH: Batch query</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
