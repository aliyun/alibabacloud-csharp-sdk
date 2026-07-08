// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ExportHotTopicPlanningProposalsRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Custom viewpoint ID. Use this parameter for custom viewpoint topic planning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>025c6cee437741368098b790c90166f8</para>
        /// </summary>
        [NameInMap("CustomViewPointIds")]
        [Validation(Required=false)]
        public List<string> CustomViewPointIds { get; set; }

        /// <summary>
        /// <para>Document export format</para>
        /// <list type="bullet">
        /// <item><description><para>word: Export as a Word document</para>
        /// </description></item>
        /// <item><description><para>xmind: Export as an XMind file</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>word</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>Filter topic planning documents by title</para>
        /// </summary>
        [NameInMap("Titles")]
        [Validation(Required=false)]
        public List<string> Titles { get; set; }

        /// <summary>
        /// <para>Hot list topic</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>Hot list source</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜源</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <para>Topic planning type</para>
        /// <list type="bullet">
        /// <item><description><para>CustomViewPoints: Custom viewpoint</para>
        /// </description></item>
        /// <item><description><para>HotViewPoints: Popular viewpoint</para>
        /// </description></item>
        /// <item><description><para>TimedViewPoints: Time-sensitive viewpoint</para>
        /// </description></item>
        /// <item><description><para>WebReviewPoints: Public viewpoint</para>
        /// </description></item>
        /// <item><description><para>FreshViewPoints: Fresh viewpoint</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CustomViewPoints</para>
        /// </summary>
        [NameInMap("ViewPointType")]
        [Validation(Required=false)]
        public string ViewPointType { get; set; }

    }

}
