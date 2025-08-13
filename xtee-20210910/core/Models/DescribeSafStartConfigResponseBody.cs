// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafStartConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafStartConfigResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafStartConfigResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>List of device types.</para>
            /// </summary>
            [NameInMap("deviceTypes")]
            [Validation(Required=false)]
            public List<string> DeviceTypes { get; set; }

            /// <summary>
            /// <para>Event codes.</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public List<string> EventCodes { get; set; }

            /// <summary>
            /// <para>Configuration language details.</para>
            /// </summary>
            [NameInMap("languages")]
            [Validation(Required=false)]
            public List<string> Languages { get; set; }

            /// <summary>
            /// <para>Server region</para>
            /// </summary>
            [NameInMap("serverRegions")]
            [Validation(Required=false)]
            public List<string> ServerRegions { get; set; }

        }

    }

}
