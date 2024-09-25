// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the contiguous EIP group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eipsg-2zett8ba055tbsxme****</para>
        /// </summary>
        [NameInMap("EipSegmentInstanceId")]
        [Validation(Required=false)]
        public string EipSegmentInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7A6301A-64BA-41EC-8284-8F4838C15D1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
