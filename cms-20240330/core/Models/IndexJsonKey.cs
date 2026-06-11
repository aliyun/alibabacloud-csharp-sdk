// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IndexJsonKey : TeaModel {
        /// <summary>
        /// <para>Specifies whether the field contains Chinese characters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The field contains Chinese characters.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The field does not contain Chinese characters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>The field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
