// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListModelsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The collections to which the model belongs. You can specify multiple collections. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI4D,QuickStart</para>
        /// </summary>
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public string Collections { get; set; }

        /// <summary>
        /// <para>The conditions.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string ConditionsShrink { get; set; }

        /// <summary>
        /// <para>The domain. This parameter is used to filter the model list by domain. Examples: nlp (natural language processing) and cv (computer vision).</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The label string. This parameter is used to filter the list. Models are returned if their label keys or values contain the specified string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The model name. This parameter is used to filter the model list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sentiment analysis</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The order in which to sort the results of a paged query. The default value is ASC.</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// <item><description><para>DESC: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The model source. This parameter is used to filter the model list by community or organization. Examples: ModelScope and HuggingFace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number of the model list. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of models to display on each page in a paged query. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The provider. If you specify a provider, only the public models from that provider are returned. If you leave this parameter empty, your own models are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The query condition. This parameter performs a fuzzy match on ModelName, Domain, Task, LabelKey, and LabelValue. For example, if you enter nlp, models that match in any of these fields are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The field to use for sorting in a paged query. Currently, only the GmtCreateTime field is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The task. This parameter is used to filter the model list by task type. Example: text-classification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-classification</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <para>The workspace ID. The returned list contains only the models in the specified workspace. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>324**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
