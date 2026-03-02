// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Relation : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TableB</para>
        /// </summary>
        [NameInMap("destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>664cc64d-5dea-4ad3-9ee4-8432a874****</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TableA</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
