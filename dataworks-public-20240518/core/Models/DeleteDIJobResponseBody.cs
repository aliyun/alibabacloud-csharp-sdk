// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteDIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D33D4A51-5845-579A-B4BA-FAADD0F83D53</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
