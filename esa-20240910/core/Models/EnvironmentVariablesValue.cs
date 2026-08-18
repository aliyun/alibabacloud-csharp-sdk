// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class EnvironmentVariablesValue : TeaModel {
        /// <summary>
        /// <para>The environment variable type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>plain_text</c>: plain text</description></item>
        /// <item><description><c>secret_text</c>: encrypted text</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>plain_text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The environment variable value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
