// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6B82A9EF-9961-5A31-A19F-009B709xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
