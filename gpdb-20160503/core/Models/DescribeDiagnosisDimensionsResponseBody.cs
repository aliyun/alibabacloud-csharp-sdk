// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ADCAACA-E0E8-5319-AE3B-E260E957BDF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The names of the database accounts.</para>
        /// </summary>
        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
