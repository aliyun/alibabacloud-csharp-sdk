// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricRequest : TeaModel {
        [NameInMap("codeList")]
        [Validation(Required=false)]
        public List<int?> CodeList { get; set; }

        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        [NameInMap("operationList")]
        [Validation(Required=false)]
        public List<string> OperationList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project_a</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        [NameInMap("tableList")]
        [Validation(Required=false)]
        public List<string> TableList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("topN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
