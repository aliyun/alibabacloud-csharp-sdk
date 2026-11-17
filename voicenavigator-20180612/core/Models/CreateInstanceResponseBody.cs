// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the newly created intelligent navigation scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c28fc549-d88f-4f6e-85ad-a0806e5e39c0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1C878-63EC-50EF-B7A0-024F98B09129</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
