// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateDataAgentAccuracyTestResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDataAgentAccuracyTestResponseBodyData Data { get; set; }
        public class UpdateDataAgentAccuracyTestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the accuracy test item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>at-106n4rg17gv9fxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccuracyTest")]
            [Validation(Required=false)]
            public string AccuracyTest { get; set; }

            /// <summary>
            /// <para>Agent Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>cu0cs*******mf</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The evaluation dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-9z6***74al</para>
            /// </summary>
            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public string Dataset { get; set; }

            /// <summary>
            /// <para>The data source information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DataSourceType&quot;:&quot;remote_data_center&quot;,&quot;DmsDatabaseId&quot;:&quot;f-894<em><b>01m&quot;,&quot;FileId&quot;:&quot;f-894</b></em>01m&quot;,&quot;Database&quot;:&quot;data.csv&quot;,&quot;Tables&quot;:[&quot;example&quot;],&quot;TableIds&quot;:[&quot;aij5***qf8&quot;],&quot;RegionId&quot;:&quot;cn-hangzhou&quot;}]</para>
            /// </summary>
            [NameInMap("Datasource")]
            [Validation(Required=false)]
            public string Datasource { get; set; }

            /// <summary>
            /// <para>The description of the evaluation item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer Agent\&quot;s Evaluation</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The accuracy evaluation criteria. An empty value indicates the default criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EvaluationPrompt")]
            [Validation(Required=false)]
            public string EvaluationPrompt { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The maximum concurrency limit for the evaluation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public int? MaxConcurrent { get; set; }

            /// <summary>
            /// <para>The analysis mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The name of the evaluation item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Evaluation_for_customagent213</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Reserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedDelete")]
            [Validation(Required=false)]
            public bool? NeedDelete { get; set; }

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
        /// <para>The error code returned when an exception occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.                                 </description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
