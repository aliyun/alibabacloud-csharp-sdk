// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DeleteEciScalingConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// <para>The request ID is consistently returned in the response, irrespective of whether the request is executed successfully or encounters an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D5B0AD-3B00-4A9B-9911-6D5303B06712</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
