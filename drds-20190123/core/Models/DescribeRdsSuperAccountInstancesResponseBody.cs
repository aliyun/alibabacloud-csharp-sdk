// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsSuperAccountInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The privileged accounts.</para>
        /// </summary>
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeRdsSuperAccountInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeRdsSuperAccountInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<string> DbInstance { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D64DE5944A1E541E0******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
