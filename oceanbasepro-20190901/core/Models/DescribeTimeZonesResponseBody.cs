// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>DescribeTimeZones</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The description of the time zone.</para>
        /// </summary>
        [NameInMap("TimeZones")]
        [Validation(Required=false)]
        public DescribeTimeZonesResponseBodyTimeZones TimeZones { get; set; }
        public class DescribeTimeZonesResponseBodyTimeZones : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public string Default { get; set; }

            /// <summary>
            /// <para>The list of time zones.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeTimeZonesResponseBodyTimeZonesList> List { get; set; }
            public class DescribeTimeZonesResponseBodyTimeZonesList : TeaModel {
                /// <summary>
                /// <para>Example 1</para>
                /// 
                /// <b>Example:</b>
                /// <para>(GMT+8:00) Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeTimeZones</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

    }

}
