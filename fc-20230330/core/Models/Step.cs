// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Step : TeaModel {
        /// <summary>
        /// <para>The step parameters.</para>
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <para>The step type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER, WORKDIR, ENV, RUN</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
