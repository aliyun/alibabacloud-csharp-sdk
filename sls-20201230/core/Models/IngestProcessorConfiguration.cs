// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class IngestProcessorConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>keep</para>
        /// </summary>
        [NameInMap("parseFail")]
        [Validation(Required=false)]
        public string ParseFail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| project content</description></item>
        /// </list>
        /// </summary>
        [NameInMap("spl")]
        [Validation(Required=false)]
        public string Spl { get; set; }

    }

}
