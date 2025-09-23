// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectMainBodyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectMainBodyResponseBodyData Data { get; set; }
        public class DetectMainBodyResponseBodyData : TeaModel {
            [NameInMap("Location")]
            [Validation(Required=false)]
            public DetectMainBodyResponseBodyDataLocation Location { get; set; }
            public class DetectMainBodyResponseBodyDataLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>320</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>583</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>28</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2E59C333-5480-4231-A8AB-BEE1001EA7FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
