// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class DeleteTaskRequest : TeaModel {
        /// <summary>
        /// <para>The data retention policy for resources. If this parameter is not specified, it indicates that the deletion is not confirmed. If the node has resources or the resource status is unknown, the API returns a confirmation fault. If you set this parameter to RETAIN, only the node management record is deleted and the cloud resources are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RETAIN</para>
        /// </summary>
        [NameInMap("resourceRetentionPolicy")]
        [Validation(Required=false)]
        public string ResourceRetentionPolicy { get; set; }

    }

}
