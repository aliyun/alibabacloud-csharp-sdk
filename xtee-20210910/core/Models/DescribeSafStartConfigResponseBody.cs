// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafStartConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafStartConfigResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafStartConfigResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The device type list.</para>
            /// </summary>
            [NameInMap("deviceTypes")]
            [Validation(Required=false)]
            public List<string> DeviceTypes { get; set; }

            /// <summary>
            /// <para>The event codes.</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public List<string> EventCodes { get; set; }

            /// <summary>
            /// <para>The configuration language details.</para>
            /// </summary>
            [NameInMap("languages")]
            [Validation(Required=false)]
            public List<string> Languages { get; set; }

            /// <summary>
            /// <para>The server regions.</para>
            /// </summary>
            [NameInMap("serverRegions")]
            [Validation(Required=false)]
            public List<string> ServerRegions { get; set; }

        }

    }

}
