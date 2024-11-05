// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ConfigInstanceWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bastion host for which a whitelist of public IP addresses is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1gh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47820E32-5968-45CF-982F-09CB80DC180B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
