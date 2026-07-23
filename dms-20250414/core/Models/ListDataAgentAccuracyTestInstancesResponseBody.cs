// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentAccuracyTestInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataAgentAccuracyTestInstancesResponseBodyData> Data { get; set; }
        public class ListDataAgentAccuracyTestInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The accuracy test instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>at-106n4rg17gv9fxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccuracyTestInsId")]
            [Validation(Required=false)]
            public string AccuracyTestInsId { get; set; }

            /// <summary>
            /// <para>The custom agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-4x8uzp5wjqu4xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The UID of the workspace creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20282*****7591</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Datasource")]
            [Validation(Required=false)]
            public string Datasource { get; set; }

            /// <summary>
            /// <para>The ID of the test set file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-30T07:31:09.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-30T07:31:09.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The language used for the analysis task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHINESE</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions during the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public string MaxConcurrent { get; set; }

            /// <summary>
            /// <para>The analysis mode to be tested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The custom agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent测试名称</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether sessions are displayed after analysis. This parameter is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedDelete")]
            [Validation(Required=false)]
            public string NeedDelete { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8wfig6l33n4f4xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page. You can use this parameter together with NextToken to implement paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zCXS*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-xxx-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The operation timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768270172</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
