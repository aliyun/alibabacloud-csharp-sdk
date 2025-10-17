// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDatabasesZonalResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesZonalResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesZonalResponseBodyDatabases : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeDatabasesZonalResponseBodyDatabasesAccounts> Accounts { get; set; }
            public class DescribeDatabasesZonalResponseBodyDatabasesAccounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test_acc</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Empowered</para>
                /// </summary>
                [NameInMap("PrivilegeStatus")]
                [Validation(Required=false)]
                public string PrivilegeStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public string CharacterSetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_des</para>
            /// </summary>
            [NameInMap("DBDescription")]
            [Validation(Required=false)]
            public string DBDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBStatus")]
            [Validation(Required=false)]
            public string DBStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MasterID")]
            [Validation(Required=false)]
            public string MasterID { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
