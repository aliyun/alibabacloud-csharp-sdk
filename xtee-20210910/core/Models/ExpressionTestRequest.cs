// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ExpressionTestRequest : TeaModel {
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
        /// <para>The test expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@ex_GX9rrlTq4b67 + 1001</para>
        /// </summary>
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The calculation expression variable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;age\&quot;,\&quot;code\&quot;:\&quot;age\&quot;,\&quot;fieldType\&quot;:\&quot;INT\&quot;,\&quot;id\&quot;:44809,\&quot;value\&quot;:\&quot;1\&quot;}]</para>
        /// </summary>
        [NameInMap("expressionVariable")]
        [Validation(Required=false)]
        public string ExpressionVariable { get; set; }

        /// <summary>
        /// <para>The associated variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[44659]</para>
        /// </summary>
        [NameInMap("expressionVariableIds")]
        [Validation(Required=false)]
        public string ExpressionVariableIds { get; set; }

        /// <summary>
        /// <para>The variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3144</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>The scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXPRESSION</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
