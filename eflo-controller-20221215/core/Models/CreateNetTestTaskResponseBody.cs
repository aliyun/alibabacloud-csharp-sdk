// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNetTestTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the test task. The unique identifier of a network test task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public string TestId { get; set; }

    }

}
