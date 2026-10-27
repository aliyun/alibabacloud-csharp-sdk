// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateOncallScheduleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testOncallScheduleId</para>
        /// </summary>
        [NameInMap("oncallScheduleId")]
        [Validation(Required=false)]
        public string OncallScheduleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3B311FD9-A60B-55E0-A896-A0C73*********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
