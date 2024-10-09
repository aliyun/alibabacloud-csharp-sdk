// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RegisterCustomConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The URL in which the JAR package of the custom connector is stored. The platform must be able to access this address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://flink/connector/mysql123</para>
        /// </summary>
        [NameInMap("jarUrl")]
        [Validation(Required=false)]
        public string JarUrl { get; set; }

    }

}
