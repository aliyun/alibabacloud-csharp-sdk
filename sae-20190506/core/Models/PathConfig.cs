// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PathConfig : TeaModel {
        /// <summary>
        /// <para>applicationName</para>
        /// 
        /// <b>Example:</b>
        /// <para>applicationName</para>
        /// </summary>
        [NameInMap("applicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>path</para>
        /// 
        /// <b>Example:</b>
        /// <para>/packages</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
