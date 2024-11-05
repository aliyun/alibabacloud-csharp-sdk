// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class EnableInstancePublicAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bastion host whose Internet access is enabled.</para>
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
        /// <para>D47B5043-FDD6-4FBE-976E-5FC67A23578F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
