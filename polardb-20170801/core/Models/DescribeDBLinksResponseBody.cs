// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLinksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// Details about the database links.
        /// </summary>
        [NameInMap("DBLinkInfos")]
        [Validation(Required=false)]
        public List<DescribeDBLinksResponseBodyDBLinkInfos> DBLinkInfos { get; set; }
        public class DescribeDBLinksResponseBodyDBLinkInfos : TeaModel {
            /// <summary>
            /// The ID of the source cluster that the database link connects.
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// The name of the database link.
            /// </summary>
            [NameInMap("DBLinkName")]
            [Validation(Required=false)]
            public string DBLinkName { get; set; }

            /// <summary>
            /// The name of the source database of the database link.
            /// </summary>
            [NameInMap("SourceDBName")]
            [Validation(Required=false)]
            public string SourceDBName { get; set; }

            /// <summary>
            /// The account of the destination database of the database link.
            /// </summary>
            [NameInMap("TargetAccount")]
            [Validation(Required=false)]
            public string TargetAccount { get; set; }

            /// <summary>
            /// The ID of the destination cluster that the database link connects.
            /// 
            /// > If the destination cluster is not a PolarDB for Oracle cluster, the returned value is empty.
            /// </summary>
            [NameInMap("TargetDBInstanceName")]
            [Validation(Required=false)]
            public string TargetDBInstanceName { get; set; }

            /// <summary>
            /// The name of the destination database of the database link.
            /// </summary>
            [NameInMap("TargetDBName")]
            [Validation(Required=false)]
            public string TargetDBName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
