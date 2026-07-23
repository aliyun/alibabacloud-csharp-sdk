// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class DeleteEngineConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all engine configurations with the same name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// <para>The instance ID. For information about how to obtain the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
