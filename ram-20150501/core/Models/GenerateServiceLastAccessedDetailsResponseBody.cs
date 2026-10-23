// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GenerateServiceLastAccessedDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ba536aab-84c6-43af-8bcb-aa2cae2a34e4</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEE5D280-31A0-1638-91CD-37EBDD282E7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
