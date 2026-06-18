// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDbListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDbListResponseBodyData> Data { get; set; }
        public class DescribeDbListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of accounts.</para>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeDbListResponseBodyDataAccounts> Accounts { get; set; }
            public class DescribeDbListResponseBodyDataAccounts : TeaModel {
                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root4test</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The account privilege.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReadWrite</para>
                /// </summary>
                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

            }

            /// <summary>
            /// <para>The character set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public string CharacterSetName { get; set; }

            /// <summary>
            /// <para>The database description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBDescription")]
            [Validation(Required=false)]
            public string DBDescription { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

        }

        /// <summary>
        /// <para>The response message. &quot;success&quot; is returned if the request is successful. Otherwise, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
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
