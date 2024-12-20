// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried IP address whitelists.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceIPArrayListResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceIPArrayListResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceIPArray")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray> DBInstanceIPArray { get; set; }
            public class DescribeDBInstanceIPArrayListResponseBodyItemsDBInstanceIPArray : TeaModel {
                /// <summary>
                /// <para>The attribute of the IP address whitelist. By default, this parameter is empty. A whitelist with the <c>hidden</c> attribute is not displayed in the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hidden</para>
                /// </summary>
                [NameInMap("DBInstanceIPArrayAttribute")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayAttribute { get; set; }

                /// <summary>
                /// <para>The name of the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DBInstanceIPArrayName")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayName { get; set; }

                /// <summary>
                /// <para>The IP addresses listed in the whitelist. Up to 1,000 IP addresses are contained in a whitelist and separated by commas (,). The IP addresses must use one of the following formats:</para>
                /// <list type="bullet">
                /// <item><description>0.0.0.0/0</description></item>
                /// <item><description>10.23.12.24. This is a standard IP address.</description></item>
                /// <item><description>10.23.12.24/24. This is a CIDR block. The value <c>/24</c> indicates that the prefix of the CIDR block is 24-bit long. You can replace 24 with a value in the range of <c>1 to 32</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
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
        /// <para>CB7AA0BF-BE41-480E-A3DC-C97BF85A391B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
