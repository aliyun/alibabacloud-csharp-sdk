// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class PartitionError : TeaModel {
        /// <summary>
        /// <para>The details of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auth failed</para>
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public string ErrorDetail { get; set; }

        /// <summary>
        /// <para>The partition values.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
