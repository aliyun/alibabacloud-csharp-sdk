// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCustomEndpointListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomEndpointListResponseBodyData Data { get; set; }
        public class DescribeCustomEndpointListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanDeleteCount")]
            [Validation(Required=false)]
            public int? CanDeleteCount { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<DescribeCustomEndpointListResponseBodyDataEndpoints> Endpoints { get; set; }
            public class DescribeCustomEndpointListResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// <para>[\&quot;pxc-i-vb1sqa7llp\&quot;,\&quot;pxc-i-bemprx50ad\&quot;]</para>
                /// </summary>
                [NameInMap("CnNames")]
                [Validation(Required=false)]
                public List<string> CnNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-shra****zq0j01.polarx.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxe-b6e****o4pfap1s</para>
                /// </summary>
                [NameInMap("CustomEndpointId")]
                [Validation(Required=false)]
                public string CustomEndpointId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-hz****zoxherr7</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NodeAutoEnter")]
                [Validation(Required=false)]
                public string NodeAutoEnter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>same_azone_as_last</para>
                /// </summary>
                [NameInMap("NodeRole")]
                [Validation(Required=false)]
                public string NodeRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>created</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-8vbkw****5yh4nrd639ih</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-uf61h****dj1zg5fqp5x7</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6352AC16-76BF-5135-B1EA-ED49293526E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
