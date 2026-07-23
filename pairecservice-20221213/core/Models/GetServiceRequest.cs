// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetServiceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
