// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class StartInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bastion host that you enable.</para>
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
        /// <para>0F85AE0A-6A87-48F3-A0C7-90B998788A36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
