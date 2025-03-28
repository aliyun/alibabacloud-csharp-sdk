// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ServiceCommandStep : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>./</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s invoke</para>
        /// </summary>
        [NameInMap("run")]
        [Validation(Required=false)]
        public string Run { get; set; }

    }

}
