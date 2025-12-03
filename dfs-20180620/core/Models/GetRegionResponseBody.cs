// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class GetRegionResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<GetRegionResponseBodyAvailableZones> AvailableZones { get; set; }
        public class GetRegionResponseBodyAvailableZones : TeaModel {
            [NameInMap("Options")]
            [Validation(Required=false)]
            public List<GetRegionResponseBodyAvailableZonesOptions> Options { get; set; }
            public class GetRegionResponseBodyAvailableZonesOptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HDFS</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AEC07154-5A4C-4B34-BB74-0893C6E9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
