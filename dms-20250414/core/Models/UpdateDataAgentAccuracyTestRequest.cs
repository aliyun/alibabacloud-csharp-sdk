// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateDataAgentAccuracyTestRequest : TeaModel {
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
        /// <para>The new custom agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CustomerAgentId")]
        [Validation(Required=false)]
        public string CustomerAgentId { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;DataSourceType\&quot;:\&quot;database\&quot;,\&quot;RegionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;DmsInstanceId\&quot;:\&quot;27xxxxx\&quot;,\&quot;DmsDatabaseId\&quot;:\&quot;752xxxxx\&quot;,\&quot;Database\&quot;:\&quot;employees\&quot;,\&quot;Tables\&quot;:[\&quot;employees\&quot;,\&quot;salaries\&quot;,\&quot;departments\&quot;]}]</para>
        /// </summary>
        [NameInMap("Dataset")]
        [Validation(Required=false)]
        public string Dataset { get; set; }

        [NameInMap("Datasource")]
        [Validation(Required=false)]
        public string Datasource { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The current Data Management unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

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
        /// <para>The file ID in the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-8*******01m</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent sessions during the test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxConcurrent")]
        [Validation(Required=false)]
        public int? MaxConcurrent { get; set; }

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
        /// <para>The name of the test item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether sessions are displayed after analysis. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no use</para>
        /// </summary>
        [NameInMap("NeedDelete")]
        [Validation(Required=false)]
        public bool? NeedDelete { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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

}
