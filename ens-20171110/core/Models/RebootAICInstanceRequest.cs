// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RebootAICInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AIC instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic-instance****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the AIC instance groups.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-instance****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

    }

}
