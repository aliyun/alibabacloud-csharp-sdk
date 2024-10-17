// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDesignProjectInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about the schema design project.</para>
        /// </summary>
        [NameInMap("ProjectInfo")]
        [Validation(Required=false)]
        public GetTableDesignProjectInfoResponseBodyProjectInfo ProjectInfo { get; set; }
        public class GetTableDesignProjectInfoResponseBodyProjectInfo : TeaModel {
            /// <summary>
            /// <para>The information about the change base database of the schema design ticket.</para>
            /// </summary>
            [NameInMap("BaseDatabase")]
            [Validation(Required=false)]
            public GetTableDesignProjectInfoResponseBodyProjectInfoBaseDatabase BaseDatabase { get; set; }
            public class GetTableDesignProjectInfoResponseBodyProjectInfoBaseDatabase : TeaModel {
                /// <summary>
                /// <para>The alias of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>poc_test</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11****</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POLARDB</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The type of the environment in which the database instance is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>product</b>: production environment.</description></item>
                /// <item><description><b>dev</b>: development environment.</description></item>
                /// <item><description><b>pre</b>: pre-release environment.</description></item>
                /// <item><description><b>test</b>: test environment.</description></item>
                /// <item><description><b>sit</b>: system integration testing (SIT) environment.</description></item>
                /// <item><description><b>uat</b>: user acceptance testing (UAT) environment.</description></item>
                /// <item><description><b>pet</b>: stress testing environment.</description></item>
                /// <item><description><b>stag</b>: staging environment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bk_atc020</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:schema_name@127.0.XX.XX">schema_name@127.0.XX.XX</a></para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user who created the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>71****</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// <para>The description of the schema design project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the ticket was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-23 02:57:01</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the ticket was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-23 02:57:01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The state of the schema design project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DESIGN</b>: The schema is being designed.</description></item>
            /// <item><description><b>PUBLISHED</b>: The schema is published.</description></item>
            /// <item><description><b>CLOSE</b>: The ticket is closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DESIGN</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the schema design project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the request ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48778434-5796-571A-8455-A59146588401</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
