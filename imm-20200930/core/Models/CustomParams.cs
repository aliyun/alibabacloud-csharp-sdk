// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CustomParams : TeaModel {
        /// <summary>
        /// <para>The name of the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normalize</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<Property> Properties { get; set; }

    }

}
