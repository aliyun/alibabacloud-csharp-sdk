// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageBodiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The human bodies.</para>
        /// </summary>
        [NameInMap("Bodies")]
        [Validation(Required=false)]
        public List<Body> Bodies { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501339F9-4B70-0CE2-AB8C-866C********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
