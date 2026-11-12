// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeEncryptionDBSecretRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. Usage notes: This parameter is required. If it is not provided, the InvalidDBClusterId.Malformed (400) error is returned. This API supports only PolarDB for MySQL clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-wz9fb5nn44u1d****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
