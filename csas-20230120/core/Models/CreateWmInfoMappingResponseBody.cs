// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmInfoMappingResponseBody : TeaModel {
        /// <summary>
        /// <para>The mapping result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmInfoMappingResponseBodyData Data { get; set; }
        public class CreateWmInfoMappingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The mapped digital-format watermark information. This value can be used to look up the corresponding string-format watermark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("WmInfoUint")]
            [Validation(Required=false)]
            public long? WmInfoUint { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
