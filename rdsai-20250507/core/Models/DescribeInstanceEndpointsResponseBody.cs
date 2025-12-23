// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceEndpointsResponseBody : TeaModel {
        [NameInMap("DBInstanceEndpoints")]
        [Validation(Required=false)]
        public List<DescribeInstanceEndpointsResponseBodyDBInstanceEndpoints> DBInstanceEndpoints { get; set; }
        public class DescribeInstanceEndpointsResponseBodyDBInstanceEndpoints : TeaModel {
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        [NameInMap("InstanceEndpoints")]
        [Validation(Required=false)]
        public List<DescribeInstanceEndpointsResponseBodyInstanceEndpoints> InstanceEndpoints { get; set; }
        public class DescribeInstanceEndpointsResponseBodyInstanceEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8.152.XXX.XXX:8000</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.152.XXX.XXX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32DEFB4A-861F-5D1D-ADD5-918E4FD7AB8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
