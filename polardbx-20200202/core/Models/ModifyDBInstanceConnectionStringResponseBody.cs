// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyDBInstanceConnectionStringResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The new connection string information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBInstanceConnectionStringResponseBodyData Data { get; set; }
        public class ModifyDBInstanceConnectionStringResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2.polarx.huhehaote.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-unrf5ssig0ecg8</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The network type of the connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DBInstanceNetType")]
            [Validation(Required=false)]
            public string DBInstanceNetType { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3300</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// <para>The response message. This is typically an error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is a unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3cf535c-a585-11ea-8263-00163e04d3a7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
