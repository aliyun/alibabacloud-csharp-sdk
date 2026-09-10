// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisableMaintainWindowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123-12-312-31-23123</para>
        /// </summary>
        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123-3213-345-9941-345345345</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
