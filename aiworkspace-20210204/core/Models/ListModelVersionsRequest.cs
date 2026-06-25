// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListModelVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The approval status. This parameter is used to filter the model version list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The model version is pending approval.</para>
        /// </description></item>
        /// <item><description><para>Approved: The model version is approved for publishing.</para>
        /// </description></item>
        /// <item><description><para>Rejected: The model version is rejected for publishing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <para>The model format. This parameter is used to filter the model version list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OfflineModel</para>
        /// </description></item>
        /// <item><description><para>SavedModel</para>
        /// </description></item>
        /// <item><description><para>Keras H5</para>
        /// </description></item>
        /// <item><description><para>Frozen Pb</para>
        /// </description></item>
        /// <item><description><para>Caffe Prototxt</para>
        /// </description></item>
        /// <item><description><para>TorchScript</para>
        /// </description></item>
        /// <item><description><para>XGBoost</para>
        /// </description></item>
        /// <item><description><para>PMML</para>
        /// </description></item>
        /// <item><description><para>AlinkModel</para>
        /// </description></item>
        /// <item><description><para>ONNX</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SavedModel</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The model framework. This parameter is used to filter the model version list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pytorch
        /// -XGBoost</para>
        /// </description></item>
        /// <item><description><para>Keras</para>
        /// </description></item>
        /// <item><description><para>Caffe</para>
        /// </description></item>
        /// <item><description><para>Alink</para>
        /// </description></item>
        /// <item><description><para>Xflow</para>
        /// </description></item>
        /// <item><description><para>TensorFlow</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TensorFlow</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The label string. This parameter is used to filter the list. Model versions that have the specified string in the key or value of their labels are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The order in which to sort the entries in the paged query. The default value is ASC.</para>
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
        /// <para>The page number of the model version list. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to use for sorting in the paged query. Currently, the GmtCreateTime field is used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If the source type is Custom, this parameter is not restricted.</para>
        /// </description></item>
        /// <item><description><para>If the source is PAIFlow or TrainingService, the format is as follows:</para>
        /// </description></item>
        /// </list>
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>where:</para>
        /// <list type="bullet">
        /// <item><description><para>region is the Alibaba Cloud region ID.</para>
        /// </description></item>
        /// <item><description><para>workspaceId is the workspace ID.</para>
        /// </description></item>
        /// <item><description><para>kind: the type. Valid values: PipelineRun (PAIFlow pipeline) and ServiceJob (training service).</para>
        /// </description></item>
        /// <item><description><para>id: the unique identifier.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the model. This parameter is used to filter the model version list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Custom (default): a custom model.</para>
        /// </description></item>
        /// <item><description><para>PAIFlow: a model from a PAI pipeline.</para>
        /// </description></item>
        /// <item><description><para>TrainingService: a model from a PAI training service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The model version name. This parameter is used to filter the model version list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
