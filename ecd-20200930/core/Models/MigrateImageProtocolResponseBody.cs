// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateImageProtocolResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the images whose protocols failed to be updated.</para>
        /// </summary>
        [NameInMap("FailedIds")]
        [Validation(Required=false)]
        public List<string> FailedIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D4E5AF5-DF28-5FE7-85C7-9F98315B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
