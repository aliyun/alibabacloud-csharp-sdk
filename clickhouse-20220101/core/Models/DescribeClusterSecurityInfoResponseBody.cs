// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DescribeClusterSecurityInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeClusterSecurityInfoResponseBodyData Data { get; set; }
        public class DescribeClusterSecurityInfoResponseBodyData : TeaModel {
            [NameInMap("SecurityIpGroups")]
            [Validation(Required=false)]
            public List<DescribeClusterSecurityInfoResponseBodyDataSecurityIpGroups> SecurityIpGroups { get; set; }
            public class DescribeClusterSecurityInfoResponseBodyDataSecurityIpGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.xx.xx,192.168.xx.xx</para>
                /// </summary>
                [NameInMap("SecurityIps")]
                [Validation(Required=false)]
                public string SecurityIps { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2371CC7A-E9C3-5817-97C9-F6333D74BA6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
