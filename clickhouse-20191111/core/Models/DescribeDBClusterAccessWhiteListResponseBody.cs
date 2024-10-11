// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the IP address whitelist.</para>
        /// </summary>
        [NameInMap("DBClusterAccessWhiteList")]
        [Validation(Required=false)]
        public DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList DBClusterAccessWhiteList { get; set; }
        public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteList : TeaModel {
            [NameInMap("IPArray")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray> IPArray { get; set; }
            public class DescribeDBClusterAccessWhiteListResponseBodyDBClusterAccessWhiteListIPArray : TeaModel {
                /// <summary>
                /// <para>The attribute of the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBClusterIPArrayAttribute { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DBClusterIPArrayName")]
                [Validation(Required=false)]
                public string DBClusterIPArrayName { get; set; }

                /// <summary>
                /// <para>The IP addresses in the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.xx.xx,192.168.xx.xx</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>905F13A4-5097-4897-A84D-527EC75FFF4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
