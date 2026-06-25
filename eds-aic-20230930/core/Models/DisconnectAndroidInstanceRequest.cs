// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DisconnectAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>If you use the Cloud Phone Matrix Edition and the instance stream pattern is collaborative mode, you can specify <c>EndUserId</c> to disconnect a specific user and invalidate the corresponding ticket.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>A list of instance IDs. You can specify 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

    }

}
