// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListUserProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListUserProjectsResponseBodyPageResult PageResult { get; set; }
        public class ListUserProjectsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of projects that the user participates in.</para>
            /// </summary>
            [NameInMap("ProjectList")]
            [Validation(Required=false)]
            public List<ListUserProjectsResponseBodyPageResultProjectList> ProjectList { get; set; }
            public class ListUserProjectsResponseBodyPageResultProjectList : TeaModel {
                /// <summary>
                /// <para>The ID of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>162112</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The ID of the compute source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public long? DataSourceId { get; set; }

                /// <summary>
                /// <para>The name of the compute source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds1</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The environment identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The creation time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-10 10:01:01</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-10 10:01:01</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1030111021</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The project mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BASIC</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012112</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The owner of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The ID of the real-time compute source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1122</para>
                /// </summary>
                [NameInMap("RealtimeDataSourceId")]
                [Validation(Required=false)]
                public long? RealtimeDataSourceId { get; set; }

                /// <summary>
                /// <para>The name of the real-time compute source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds2</para>
                /// </summary>
                [NameInMap("RealtimeDataSourceName")]
                [Validation(Required=false)]
                public string RealtimeDataSourceName { get; set; }

                /// <summary>
                /// <para>The project type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GENERAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
