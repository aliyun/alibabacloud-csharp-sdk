// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBInitializeVariableResponseBody : TeaModel {
        /// <summary>
        /// The type of the database engine. Valid values:
        /// 
        /// *   Oracle
        /// *   PostgreSQL
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The version of the database engine.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The attributes that are returned.
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeDBInitializeVariableResponseBodyVariables Variables { get; set; }
        public class DescribeDBInitializeVariableResponseBodyVariables : TeaModel {
            [NameInMap("Variable")]
            [Validation(Required=false)]
            public List<DescribeDBInitializeVariableResponseBodyVariablesVariable> Variable { get; set; }
            public class DescribeDBInitializeVariableResponseBodyVariablesVariable : TeaModel {
                /// <summary>
                /// The character set that is supported.
                /// </summary>
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                /// <summary>
                /// The language that indicates the collation of the databases that are created.
                /// 
                /// >- The language must be compatible with the character set that is specified by **CharacterSetName**.
                /// >- This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
                /// >- This parameter is optional for PolarDB for MySQL clusters.
                /// 
                /// To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose **Settings and Management** > **Databases**. Then, click **Create Database**.
                /// </summary>
                [NameInMap("Collate")]
                [Validation(Required=false)]
                public string Collate { get; set; }

                /// <summary>
                /// The language that indicates the character type of the database.
                /// 
                /// >- The language must be compatible with the character set that is specified by **CharacterSetName**.
                /// >- The specified value must be the same as the value of **Collate**.
                /// >- This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
                /// >- This parameter is optional for PolarDB for MySQL clusters.
                /// 
                /// To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose **Settings and Management** > **Databases**. Then, click **Create Database**.
                /// </summary>
                [NameInMap("Ctype")]
                [Validation(Required=false)]
                public string Ctype { get; set; }

            }

        }

    }

}
