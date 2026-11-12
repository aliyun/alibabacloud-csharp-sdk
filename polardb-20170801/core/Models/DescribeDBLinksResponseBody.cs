// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLinksResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a*************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The DBLink information set.</para>
        /// </summary>
        [NameInMap("DBLinkInfos")]
        [Validation(Required=false)]
        public List<DescribeDBLinksResponseBodyDBLinkInfos> DBLinkInfos { get; set; }
        public class DescribeDBLinksResponseBodyDBLinkInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the source cluster for the DBLink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-a*************</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the DBLink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dblink_test</para>
            /// </summary>
            [NameInMap("DBLinkName")]
            [Validation(Required=false)]
            public string DBLinkName { get; set; }

            /// <summary>
            /// <para>The name of the source database for the DBLink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb1</para>
            /// </summary>
            [NameInMap("SourceDBName")]
            [Validation(Required=false)]
            public string SourceDBName { get; set; }

            /// <summary>
            /// <para>The target database account for the DBLink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testacc</para>
            /// </summary>
            [NameInMap("TargetAccount")]
            [Validation(Required=false)]
            public string TargetAccount { get; set; }

            /// <summary>
            /// <para>The ID of the target cluster for the DBLink.</para>
            /// <remarks>
            /// <para>If the target is not a PolarDB for PostgreSQL (Compatible with Oracle) cluster, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pc-b************</para>
            /// </summary>
            [NameInMap("TargetDBInstanceName")]
            [Validation(Required=false)]
            public string TargetDBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the target database for the DBLink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb2</para>
            /// </summary>
            [NameInMap("TargetDBName")]
            [Validation(Required=false)]
            public string TargetDBName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
