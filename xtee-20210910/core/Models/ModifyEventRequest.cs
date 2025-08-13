// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyEventRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Version number (latest).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizVersion")]
        [Validation(Required=false)]
        public int? BizVersion { get; set; }

        /// <summary>
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ambiby3420</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Event name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>注册事件</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>Input parameters, JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;fieldCode\&quot;:\&quot;sessionId\&quot;,\&quot;description\&quot;:\&quot;会话ID\&quot;,\&quot;fieldRank\&quot;:0,\&quot;title\&quot;:\&quot;会话ID\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;fieldSource\&quot;:\&quot;DEFAULT\&quot;},{\&quot;fieldCode\&quot;:\&quot;tags\&quot;,\&quot;fieldRank\&quot;:1,\&quot;title\&quot;:\&quot;风险标签\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;fieldSource\&quot;:\&quot;DEFAULT\&quot;},{\&quot;fieldCode\&quot;:\&quot;score\&quot;,\&quot;fieldRank\&quot;:2,\&quot;title\&quot;:\&quot;风险分值\&quot;,\&quot;fieldType\&quot;:\&quot;DOUBLE\&quot;,\&quot;fieldSource\&quot;:\&quot;DEFAULT\&quot;},{\&quot;fieldCode\&quot;:\&quot;hitRules\&quot;,\&quot;fieldRank\&quot;:3,\&quot;title\&quot;:\&quot;命中策略\&quot;,\&quot;fieldType\&quot;:\&quot;STRING\&quot;,\&quot;fieldSource\&quot;:\&quot;DEFAULT\&quot;}]</para>
        /// </summary>
        [NameInMap("inputFieldsStr")]
        [Validation(Required=false)]
        public string InputFieldsStr { get; set; }

        /// <summary>
        /// <para>Memo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Template type</para>
        /// 
        /// <b>Example:</b>
        /// <para>暂无</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
