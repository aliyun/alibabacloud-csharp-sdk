// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20191209.Models
{
    public class ClearInstanceStorageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dbaudit-cn-78v1gc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>482EF142-BFA5-43FF-B4B0-84A4B0763639</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
