// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCapacityReservationResponseBody : TeaModel {
        /// <summary>
        /// <para>The capacity reservation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crp-bp67acfmxazb4****</para>
        /// </summary>
        [NameInMap("PrivatePoolOptionsId")]
        [Validation(Required=false)]
        public string PrivatePoolOptionsId { get; set; }

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
