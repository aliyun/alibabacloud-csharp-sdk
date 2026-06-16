// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class SaveAnalysisColumnRequest : TeaModel {
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
        /// <para>The custom columns.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;variableName\&quot;:\&quot;requestId\&quot;,\&quot;variableTitle\&quot;:\&quot;RequestId\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;eventTime\&quot;,\&quot;variableTitle\&quot;:\&quot;事件时间\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;accountId\&quot;,\&quot;variableTitle\&quot;:\&quot;账号\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;deviceId\&quot;,\&quot;variableTitle\&quot;:\&quot;设备ID\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;eventCode\&quot;,\&quot;variableTitle\&quot;:\&quot;事件编码\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;ip\&quot;,\&quot;variableTitle\&quot;:\&quot;IP\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;score\&quot;,\&quot;variableTitle\&quot;:\&quot;分值\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;tags\&quot;,\&quot;variableTitle\&quot;:\&quot;标签\&quot;,\&quot;variableType\&quot;:\&quot;SYSTEM_BIND\&quot;,\&quot;isDefault\&quot;:true},{\&quot;variableName\&quot;:\&quot;DEtest222\&quot;,\&quot;variableTitle\&quot;:\&quot;测试222\&quot;,\&quot;variableType\&quot;:\&quot;NATIVE\&quot;,\&quot;isDefault\&quot;:false}]</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

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

    }

}
