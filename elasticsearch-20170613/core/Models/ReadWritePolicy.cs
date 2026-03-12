// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ReadWritePolicy : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoGeneratePk")]
        [Validation(Required=false)]
        public bool? AutoGeneratePk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("writeHa")]
        [Validation(Required=false)]
        public bool? WriteHa { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sync</para>
        /// </summary>
        [NameInMap("writePolicy")]
        [Validation(Required=false)]
        public string WritePolicy { get; set; }

    }

}
