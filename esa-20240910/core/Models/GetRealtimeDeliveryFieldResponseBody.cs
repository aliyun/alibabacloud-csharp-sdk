// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRealtimeDeliveryFieldResponseBody : TeaModel {
        /// <summary>
        /// <para>The fields returned.</para>
        /// </summary>
        [NameInMap("FieldContent")]
        [Validation(Required=false)]
        public Dictionary<string, FieldContentValue> FieldContent { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
