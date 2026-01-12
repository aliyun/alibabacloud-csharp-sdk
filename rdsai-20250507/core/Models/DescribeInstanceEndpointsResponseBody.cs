// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoints of the RDS instance.</para>
        /// </summary>
        [NameInMap("DBInstanceEndpoints")]
        [Validation(Required=false)]
        public List<DescribeInstanceEndpointsResponseBodyDBInstanceEndpoints> DBInstanceEndpoints { get; set; }
        public class DescribeInstanceEndpointsResponseBodyDBInstanceEndpoints : TeaModel {
            /// <summary>
            /// <para>The endpoint of the RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-xxxx.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The network type of the RDS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: Internet</description></item>
            /// <item><description><b>vpc</b>: VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <para>The port used to access the RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The information about the endpoints of the RDS Supabase instance.</para>
        /// </summary>
        [NameInMap("InstanceEndpoints")]
        [Validation(Required=false)]
        public List<DescribeInstanceEndpointsResponseBodyInstanceEndpoints> InstanceEndpoints { get; set; }
        public class DescribeInstanceEndpointsResponseBodyInstanceEndpoints : TeaModel {
            /// <summary>
            /// <para>The endpoint of the RDS Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.152.XXX.XXX:8000</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The IP address used to access the RDS Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.152.XXX.XXX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The network type of the RDS Supabase instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: Internet</description></item>
            /// <item><description><b>vpc</b>: VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <para>The port used to access the RDS Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DEFB4A-861F-5D1D-ADD5-918E4FD7AB8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
