// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorNersRequest : TeaModel {
        /// <summary>
        /// <para>The type of the industry.</para>
        /// <list type="bullet">
        /// <item><description>ECOMMERCE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECOMMERCE</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
