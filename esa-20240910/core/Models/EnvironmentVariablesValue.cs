// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class EnvironmentVariablesValue : TeaModel {
        /// <summary>
        /// <para>The type of the environment variable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>plain_text</c>: Plain text.</description></item>
        /// <item><description><c>secret_text</c>: Encrypted text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>plain_text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value of the environment variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
