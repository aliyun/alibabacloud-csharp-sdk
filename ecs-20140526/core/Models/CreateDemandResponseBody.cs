// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDemandResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the demand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ed-bp11n21kq00sl71p****</para>
        /// </summary>
        [NameInMap("DemandId")]
        [Validation(Required=false)]
        public string DemandId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
