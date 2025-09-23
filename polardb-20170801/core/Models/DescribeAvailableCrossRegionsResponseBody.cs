// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAvailableCrossRegionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;cn-beijing\&quot;, \&quot;cn-shanghai\&quot;, \&quot;cn-qingdao\&quot;, \&quot;cn-shenzhen\&quot;, \&quot;cn-hongkong\&quot;]</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D685D479-B36E-52B9-98FF-8402EA01F***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
