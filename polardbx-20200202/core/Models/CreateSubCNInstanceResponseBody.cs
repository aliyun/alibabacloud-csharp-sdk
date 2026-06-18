// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateSubCNInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSubCNInstanceResponseBodyData Data { get; set; }
        public class CreateSubCNInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2209883</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6A4256F-7B83-5BD7-9AC0-72E1FAC05330</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
