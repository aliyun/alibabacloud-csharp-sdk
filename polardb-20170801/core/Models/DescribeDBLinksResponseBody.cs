// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLinksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-a*************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>Details about the database links.</para>
        /// </summary>
        [NameInMap("DBLinkInfos")]
        [Validation(Required=false)]
        public List<DescribeDBLinksResponseBodyDBLinkInfos> DBLinkInfos { get; set; }
        public class DescribeDBLinksResponseBodyDBLinkInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the source cluster that the database link connects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-a*************</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the database link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dblink_test</para>
            /// </summary>
            [NameInMap("DBLinkName")]
            [Validation(Required=false)]
            public string DBLinkName { get; set; }

            /// <summary>
            /// <para>The name of the source database of the database link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb1</para>
            /// </summary>
            [NameInMap("SourceDBName")]
            [Validation(Required=false)]
            public string SourceDBName { get; set; }

            /// <summary>
            /// <para>The account of the destination database of the database link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testacc</para>
            /// </summary>
            [NameInMap("TargetAccount")]
            [Validation(Required=false)]
            public string TargetAccount { get; set; }

            /// <summary>
            /// <para>The ID of the destination cluster that the database link connects.</para>
            /// <remarks>
            /// <para>If the destination cluster is not a PolarDB for Oracle cluster, the returned value is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pc-b************</para>
            /// </summary>
            [NameInMap("TargetDBInstanceName")]
            [Validation(Required=false)]
            public string TargetDBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the destination database of the database link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb2</para>
            /// </summary>
            [NameInMap("TargetDBName")]
            [Validation(Required=false)]
            public string TargetDBName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
