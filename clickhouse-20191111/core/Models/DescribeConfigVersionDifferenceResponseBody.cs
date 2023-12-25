// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigVersionDifferenceResponseBody : TeaModel {
        /// <summary>
        /// The values of the configuration parameters after the values of the configuration parameters are changed.
        /// </summary>
        [NameInMap("NewConfigXML")]
        [Validation(Required=false)]
        public string NewConfigXML { get; set; }

        /// <summary>
        /// The values of the configuration parameters before the values of the configuration parameters are changed.
        /// </summary>
        [NameInMap("OldConfigXML")]
        [Validation(Required=false)]
        public string OldConfigXML { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
