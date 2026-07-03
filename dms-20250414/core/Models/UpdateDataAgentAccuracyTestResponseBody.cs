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
            /// <para>The data source. We recommend that you configure this in the custom agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;DataSourceType\&quot;:\&quot;database\&quot;,\&quot;RegionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;DmsInstanceId\&quot;:\&quot;27xxxxx\&quot;,\&quot;DmsDatabaseId\&quot;:\&quot;752xxxxx\&quot;,\&quot;Database\&quot;:\&quot;employees\&quot;,\&quot;Tables\&quot;:[\&quot;employees\&quot;,\&quot;salaries\&quot;,\&quot;departments\&quot;]}]</para>
            /// </summary>
            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public string Dataset { get; set; }

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
            /// <para>The analysis mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.                                 </description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
