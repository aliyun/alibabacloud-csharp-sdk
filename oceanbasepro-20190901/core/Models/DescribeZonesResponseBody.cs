// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DescribeZones
        /// &amp;Series=normal
        /// &amp;DeployType=single
        /// &amp;Common request parameters
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>You can call this operation to learn of zones where a cluster can be created in an Alibaba Cloud region.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1-1-1</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i,cn-hangzhou-j,cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>H/I/J</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

    }

}
