// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ConfigInstanceSecurityGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bastion host for which security groups were configured.</para>
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
        /// <para>0ECCC399-4D35-48A7-8379-5C6180E66235</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
