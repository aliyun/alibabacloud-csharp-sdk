// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WorkflowParameter : TeaModel {
        /// <summary>
        /// <para>The invalid parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The invalid parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
