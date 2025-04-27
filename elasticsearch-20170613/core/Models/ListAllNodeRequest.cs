// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAllNodeRequest : TeaModel {
        /// <summary>
        /// <para>The Java Virtual Machine (JVM) heap memory usage of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("extended")]
        [Validation(Required=false)]
        public bool? Extended { get; set; }

    }

}
