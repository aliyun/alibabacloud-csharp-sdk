// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNetTestResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the test task. The unique identifier of a network test task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public string TestId { get; set; }

    }

}
