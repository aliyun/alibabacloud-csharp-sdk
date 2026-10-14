// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachEnsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. Only one ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstacneId</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The command to run on the instance, encoded in Base64 using UTF-8.</para>
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
