// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDevicesByAliasResponseBody : TeaModel {
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public QueryDevicesByAliasResponseBodyDeviceIds DeviceIds { get; set; }
        public class QueryDevicesByAliasResponseBodyDeviceIds : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public List<string> DeviceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6A9FD644-35A5-40E4-89B0-2021CAEDC1B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
