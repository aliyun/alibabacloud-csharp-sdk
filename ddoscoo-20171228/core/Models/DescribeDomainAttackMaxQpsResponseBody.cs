// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAttackMaxQpsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>613</para>
        /// </summary>
        [NameInMap("Qps")]
        [Validation(Required=false)]
        public string Qps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62F9BD81-8BCA-5B23-A3CB-3FB7CEB7A4CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
