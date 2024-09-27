// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeExternalAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent configurations in the YAML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1****</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

    }

}
