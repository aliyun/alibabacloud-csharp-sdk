// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeInstanceLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the sidecar container. You can call the <a href="https://help.aliyun.com/document_detail/2834847.html">DescribeApplicationInstances</a> to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sidecar-test-01</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>******-d700e680-aa4d-4ec1-afc2-6566b5ff4d7a-85d44d4bfc-*****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Previous")]
        [Validation(Required=false)]
        public string Previous { get; set; }

    }

}
