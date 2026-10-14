// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ReleaseInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance to be released.</para>
        /// <remarks>
        /// <para>Only expired instances can be released. You can call <a href="https://help.aliyun.com/document_detail/91478.html">DescribeInstances</a> to query the IDs and expiration status of all Anti-DDoS Proxy instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
