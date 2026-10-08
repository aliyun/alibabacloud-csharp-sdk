// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint of the new instance.</para>
        /// <remarks>
        /// <para>The <b>DBInstanceNetType</b> parameter determines whether this endpoint is an internal endpoint or a public endpoint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID of the new instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2038691****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The port of the new instance.</para>
        /// <remarks>
        /// <para>The <b>DBInstanceNetType</b> parameter determines whether this port is an internal port or a public port.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E52666CC-330E-418A-8E5B-A19E3FB42D13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
