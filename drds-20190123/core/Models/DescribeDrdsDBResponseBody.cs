// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the details about the database.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBResponseBodyData Data { get; set; }
        public class DescribeDrdsDBResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the time when the database was created. The value is in the UNIX timestamp format. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1602050276000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates the storage type of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }

            /// <summary>
            /// <para>Indicates the name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db_test</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>Indicates the type of the instance in which the database is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MASTER</b>: The instance is a primary instance.</description></item>
            /// <item><description><b>SLAVE</b>: The instance is a read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MASTER</para>
            /// </summary>
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }

            /// <summary>
            /// <para>Indicates the database sharding method.</para>
            /// <list type="bullet">
            /// <item><description><b>HORIZONTAL</b>: The database is horizontally sharded.</description></item>
            /// <item><description><b>VERTICAL</b>: The database is vertically sharded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HORIZONTAL</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Indicates the schema name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db_test*******************</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>Indicates the state of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TO_BE_INIT</b>: The database is being created.</description></item>
            /// <item><description><b>NORMAL</b>: The database is running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58FB0EC7-CF71-4E48-92FB-CF070D******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
