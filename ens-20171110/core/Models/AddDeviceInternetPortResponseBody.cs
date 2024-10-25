// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddDeviceInternetPortResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F9185F6-B6FA-514C-9E05-FFD5F0D7D156</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

    }

}
