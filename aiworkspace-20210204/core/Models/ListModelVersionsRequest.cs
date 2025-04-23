// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListModelVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The approval status based on which the model versions are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending</description></item>
        /// <item><description>Approved</description></item>
        /// <item><description>Rejected</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <para>The model format used to filter model versions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OfflineModel</description></item>
        /// <item><description>SavedModel</description></item>
        /// <item><description>Keras H5</description></item>
        /// <item><description>Frozen Pb</description></item>
        /// <item><description>Caffe Prototxt</description></item>
        /// <item><description>TorchScript</description></item>
        /// <item><description>XGBoost</description></item>
        /// <item><description>PMML</description></item>
        /// <item><description>AlinkModel</description></item>
        /// <item><description>ONNX</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SavedModel</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The framework used to filter model versions.</para>
        /// <list type="bullet">
        /// <item><description>Pytorch -XGBoost</description></item>
        /// <item><description>Keras</description></item>
        /// <item><description>Caffe</description></item>
        /// <item><description>Alink</description></item>
        /// <item><description>Xflow</description></item>
        /// <item><description>TensorFlow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TensorFlow</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The label. Model versions whose label key or label value contains a specific label are filtered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The order in which the entries are sorted by the specific field on the returned page. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC</description></item>
        /// <item><description>DESC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field used to sort the results. The GmtCreateTime field is used for sorting.</para>
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
        /// <item><description>If the source type is Custom, this field is not limited.</description></item>
        /// <item><description>If the source type is PAIFlow or TrainingService, the format is:</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>region=&lt;region_id&gt;,workspaceId=&lt;workspace_id&gt;,kind=&lt;kind&gt;,id=&lt;id&gt;
        /// </c></pre>
        /// <para>Take note of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>region is the region ID.</description></item>
        /// <item><description>workspaceId is the ID of the workspace.</description></item>
        /// <item><description>kind is the type. Valid values: PipelineRun (PAIFlow) and ServiceJob (training service).</description></item>
        /// <item><description>id is a unique identifier.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region=cn-shanghai,workspaceId=13**,kind=PipelineRun,id=run-sakdb****jdf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type used to filter model versions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom (default)</description></item>
        /// <item><description>PAIFlow</description></item>
        /// <item><description>TrainingService</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAIFlow</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The model version used to filter model versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
