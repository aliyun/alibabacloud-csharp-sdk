// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated and will not return a value.</para>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/86910.html">DescribeDBInstanceAttribute</a> interface to view the connection address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****.gpdb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and will not return a value.</para>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/86910.html">DescribeDBInstanceAttribute</a> interface to view the port number of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3432</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5414A4E5-4C36-4461-95FC-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
