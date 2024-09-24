// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIPArrayListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details about the IP address whitelists.</para>
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
                /// <para>The attribute of the IP address whitelist. By default, this parameter is empty.</para>
                /// <remarks>
                /// <para> A whitelist with the hidden attribute does not appear in the console. Such IP address whitelists are used to access Alibaba Cloud services, such as Data Transmission Service (DTS).</para>
                /// </remarks>
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
                /// <para>rds_default</para>
                /// </summary>
                [NameInMap("DBInstanceIPArrayName")]
                [Validation(Required=false)]
                public string DBInstanceIPArrayName { get; set; }

                /// <summary>
                /// <para>The IP addresses in the IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>The type of the IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2B6AF71-DC32-4055-B477-43B348798D10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
