// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateModelServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ms-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelServiceId")]
        [Validation(Required=false)]
        public string ModelServiceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A85BAF-1089-4CDF-A82F-0A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
