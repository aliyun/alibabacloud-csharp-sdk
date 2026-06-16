// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateCustVariableRequest : TeaModel {
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
        /// <para>{&quot;relationship&quot;:&quot;and&quot;,&quot;list&quot;:[{&quot;deepCount&quot;:1,&quot;left&quot;:{&quot;hasRightVariable&quot;:true,&quot;fieldType&quot;:&quot;INT&quot;,&quot;functionName&quot;:&quot;&quot;,&quot;leftVariableType&quot;:&quot;NATIVE&quot;,&quot;name&quot;:&quot;DEtest222&quot;,&quot;operatorCode&quot;:&quot;equals&quot;},&quot;right&quot;:{&quot;rightVariableType&quot;:&quot;constant&quot;,&quot;name&quot;:&quot;11&quot;,&quot;functionName&quot;:&quot;&quot;},&quot;operatorCode&quot;:&quot;equals&quot;}]}</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The creation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip调用次数累计描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The event code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ahqhsw7665,de_agbzfi5134</para>
        /// </summary>
        [NameInMap("eventCodes")]
        [Validation(Required=false)]
        public string EventCodes { get; set; }

        /// <summary>
        /// <para>The value type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EARLIEST</para>
        /// </summary>
        [NameInMap("historyValueType")]
        [Validation(Required=false)]
        public string HistoryValueType { get; set; }

        /// <summary>
        /// <para>The cumulative object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>age</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>The return type of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The subject object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>The time slice type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CURRENT</para>
        /// </summary>
        [NameInMap("timeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip调用次数累计</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The number of time units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("twCount")]
        [Validation(Required=false)]
        public int? TwCount { get; set; }

        /// <summary>
        /// <para>The variable type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISTINCT</para>
        /// </summary>
        [NameInMap("velocityFC")]
        [Validation(Required=false)]
        public string VelocityFC { get; set; }

        /// <summary>
        /// <para>The time slice unit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY_1</para>
        /// </summary>
        [NameInMap("velocityTW")]
        [Validation(Required=false)]
        public string VelocityTW { get; set; }

    }

}
