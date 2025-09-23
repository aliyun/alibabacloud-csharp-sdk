// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectWhiteBaseImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectWhiteBaseImageResponseBodyData Data { get; set; }
        public class DetectWhiteBaseImageResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectWhiteBaseImageResponseBodyDataElements> Elements { get; set; }
            public class DetectWhiteBaseImageResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WhiteBase")]
                [Validation(Required=false)]
                public int? WhiteBase { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7A7F9EEB-44C4-4592-9089-A6185B222B23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
