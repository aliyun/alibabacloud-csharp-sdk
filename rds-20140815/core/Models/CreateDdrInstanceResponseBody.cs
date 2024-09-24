// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDdrInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint that is used to connect to the destination instance.</para>
        /// <remarks>
        /// <para> The <b>DBInstanceNetType</b> parameter indicates whether the endpoint is internal or public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxxx.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The destination instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2038691xxxxx</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The port number that is used to connect to the destination instance.</para>
        /// <remarks>
        /// <para><b>DBInstanceNetType</b> indicates whether the port is internal or public.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E52666CC-330E-418A-8E5B-A19E3FB42D13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
