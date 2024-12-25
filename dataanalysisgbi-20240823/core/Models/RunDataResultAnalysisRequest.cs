// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823.Models
{
    public class RunDataResultAnalysisRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("analysisMode")]
        [Validation(Required=false)]
        public string AnalysisMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF76AD3F-8B32-567E-819B-0D3738917006</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sqlData")]
        [Validation(Required=false)]
        public RunDataResultAnalysisRequestSqlData SqlData { get; set; }
        public class RunDataResultAnalysisRequestSqlData : TeaModel {
            [NameInMap("column")]
            [Validation(Required=false)]
            public List<string> Column { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Data { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2v3934xtp49esw64</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
