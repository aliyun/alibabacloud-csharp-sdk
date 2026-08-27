// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c036e78-9e82-428e-afd6-177f5d04****</para>
        /// </summary>
        [NameInMap("StackGroupId")]
        [Validation(Required=false)]
        public string StackGroupId { get; set; }

    }

}
