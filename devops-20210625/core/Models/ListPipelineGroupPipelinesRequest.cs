// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelineGroupPipelinesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("executeEndTime")]
        [Validation(Required=false)]
        public long? ExecuteEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1586863220000</para>
        /// </summary>
        [NameInMap("executeStartTime")]
        [Validation(Required=false)]
        public long? ExecuteStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaa</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING,SUCCESS</para>
        /// </summary>
        [NameInMap("resultStatusList")]
        [Validation(Required=false)]
        public string ResultStatusList { get; set; }

    }

}
