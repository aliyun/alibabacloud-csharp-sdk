// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyCustVariableRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values: </para>
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
        /// <para>{\&quot;currentId\&quot;:1,\&quot;deepCount\&quot;:0,\&quot;list\&quot;:[{\&quot;currentId\&quot;:2,\&quot;deepCount\&quot;:1,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;__hit_rules\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;hitRules\&quot;,\&quot;operatorCode\&quot;:\&quot;deNotInNameList\&quot;},\&quot;operatorCode\&quot;:\&quot;deNotInNameList\&quot;,\&quot;parentId\&quot;:1,\&quot;right\&quot;:{\&quot;code\&quot;:\&quot;\&quot;nl_Xcufc8wV6624\&quot;\&quot;,\&quot;name\&quot;:\&quot;nl_Xcufc8wV6624\&quot;,\&quot;rightVariableType\&quot;:\&quot;variable\&quot;}},{\&quot;currentId\&quot;:3,\&quot;deepCount\&quot;:1,\&quot;list\&quot;:[{\&quot;currentId\&quot;:4,\&quot;deepCount\&quot;:2,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;__v_safde\&quot;,\&quot;fieldType\&quot;:\&quot;DOUBLE\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:true,\&quot;name\&quot;:\&quot;score\&quot;,\&quot;operatorCode\&quot;:\&quot;equals\&quot;},\&quot;operatorCode\&quot;:\&quot;equals\&quot;,\&quot;parentId\&quot;:3,\&quot;right\&quot;:{\&quot;code\&quot;:\&quot;\&quot;99\&quot;\&quot;,\&quot;name\&quot;:\&quot;99\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;}},{\&quot;currentId\&quot;:5,\&quot;deepCount\&quot;:2,\&quot;left\&quot;:{\&quot;code\&quot;:\&quot;queryPhoneSimulatorInfo(deviceToken)?\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;hasRightVariable\&quot;:false,\&quot;name\&quot;:\&quot;<b>device-test01</b>\&quot;,\&quot;operatorCode\&quot;:\&quot;isNotEmptyWrapper\&quot;},\&quot;operatorCode\&quot;:\&quot;isNotEmptyWrapper\&quot;,\&quot;parentId\&quot;:3,\&quot;right\&quot;:{\&quot;functionName\&quot;:\&quot;\&quot;,\&quot;name\&quot;:\&quot;\&quot;,\&quot;rightVariableType\&quot;:\&quot;constant\&quot;}}],\&quot;parentId\&quot;:1,\&quot;relationship\&quot;:\&quot;and\&quot;}],\&quot;parentId\&quot;:0,\&quot;relationship\&quot;:\&quot;and\&quot;}</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>Data version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("dataVersion")]
        [Validation(Required=false)]
        public long? DataVersion { get; set; }

        /// <summary>
        /// <para>Description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Event code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_abuse_pro,account_abuse</para>
        /// </summary>
        [NameInMap("eventCodes")]
        [Validation(Required=false)]
        public string EventCodes { get; set; }

        /// <summary>
        /// <para>Variable ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>376773</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Variable name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dxkkLw8fe18</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Output</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
