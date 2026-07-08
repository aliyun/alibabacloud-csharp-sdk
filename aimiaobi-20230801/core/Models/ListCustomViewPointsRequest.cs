// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListCustomViewPointsRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The viewpoint to filter by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>观点</para>
        /// </summary>
        [NameInMap("Attitude")]
        [Validation(Required=false)]
        public string Attitude { get; set; }

        /// <summary>
        /// <para>A list of viewpoints to filter by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>观点
        ///      *</para>
        /// </summary>
        [NameInMap("Attitudes")]
        [Validation(Required=false)]
        public List<string> Attitudes { get; set; }

        /// <summary>
        /// <para>The ID of the custom viewpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>461591f4880747f890702c1b90494d1a</para>
        /// </summary>
        [NameInMap("CustomViewPointId")]
        [Validation(Required=false)]
        public string CustomViewPointId { get; set; }

        /// <summary>
        /// <para>A list of custom viewpoint IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ece3d1212e04c9ca716ae2486228f3f</para>
        /// </summary>
        [NameInMap("CustomViewPointIds")]
        [Validation(Required=false)]
        public List<string> CustomViewPointIds { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The topic of the hot list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The topic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d20ed14db0840efb1c7eaaf4d46352b</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

    }

}
