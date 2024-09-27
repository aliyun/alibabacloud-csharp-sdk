// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImageComponentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the image component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ic-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ImageComponentId")]
        [Validation(Required=false)]
        public string ImageComponentId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
