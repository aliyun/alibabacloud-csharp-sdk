// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachEnsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can specify only one instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstacneId</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The command that you want to execute on the instance. The command must be encoded in Base64 or UTF-8.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wget d2dldCBodHRwOi8vYWxpYWNzLWs4cy1jbxxxx</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public string Scripts { get; set; }

    }

}
