// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class IndexJsonKey : TeaModel {
        /// <summary>
        /// <para>Specifies whether the field contains Chinese characters. This parameter is required only when the <b>type</b> parameter is set to <b>text</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The field contains Chinese characters.</description></item>
        /// <item><description>false: The field does not contain Chinese characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
