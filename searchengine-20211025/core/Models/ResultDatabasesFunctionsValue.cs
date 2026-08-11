// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ResultDatabasesFunctionsValue : TeaModel {
        /// <summary>
        /// <para>The name of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gfasdds2****2wfrkv</para>
        /// </summary>
        [NameInMap("signatures")]
        [Validation(Required=false)]
        public string Signatures { get; set; }

    }

}
