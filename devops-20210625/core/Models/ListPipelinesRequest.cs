// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListPipelinesRequest : TeaModel {
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
        /// <para>112122121</para>
        /// </summary>
        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("executeAccountIds")]
        [Validation(Required=false)]
        public string ExecuteAccountIds { get; set; }

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
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaaaaaaaa</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>流水线</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING,SUCCESS</para>
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

    }

}
