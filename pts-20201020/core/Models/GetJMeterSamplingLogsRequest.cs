// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterSamplingLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the load generator. This parameter is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14238000</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637157073000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637157076000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The keyword. You can use the keyword in the value of <b>SceneName</b> for fuzzy searching or use the value of <b>SceneID</b> for exact searching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum response time. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxRT")]
        [Validation(Required=false)]
        public int? MaxRT { get; set; }

        /// <summary>
        /// <para>The minimum response time. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinRT")]
        [Validation(Required=false)]
        public int? MinRT { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the report.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7R4RE352</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// <para>The ID of the sampler. The value starts from 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplerId")]
        [Validation(Required=false)]
        public int? SamplerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the sampling is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The name of the thread. Fuzzy searching is supported. If you specify multiple threads, separate the threads with spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public string Thread { get; set; }

    }

}
