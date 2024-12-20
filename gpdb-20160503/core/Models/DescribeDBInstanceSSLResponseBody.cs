// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.gpdbmaster.xxx.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5FF8636-37F6-4CE0-8002-F8734C62C686</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL encryption is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

        /// <summary>
        /// <para>The expiration time of the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-05T09:05:53Z</para>
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

    }

}
