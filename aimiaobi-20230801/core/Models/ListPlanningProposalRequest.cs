// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListPlanningProposalRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e7b26a9e1211444db8f0a984361a5e0f</para>
        /// </summary>
        [NameInMap("CustomViewPointId")]
        [Validation(Required=false)]
        public string CustomViewPointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27971fc8f3ce4ed58c7e7fc4b503e432</para>
        /// </summary>
        [NameInMap("CustomViewPointIds")]
        [Validation(Required=false)]
        public List<string> CustomViewPointIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>标题
        ///      *</para>
        /// </summary>
        [NameInMap("Titles")]
        [Validation(Required=false)]
        public List<string> Titles { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜源</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-10_08</para>
        /// </summary>
        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CustomViewPoints</para>
        /// </summary>
        [NameInMap("ViewPointType")]
        [Validation(Required=false)]
        public string ViewPointType { get; set; }

    }

}
