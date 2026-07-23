// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ApplyEngineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can obtain this by calling the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
