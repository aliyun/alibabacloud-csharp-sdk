// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MLDataSetParam : TeaModel {
        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-console</para>
        /// </summary>
        [NameInMap("createBy")]
        [Validation(Required=false)]
        public string CreateBy { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1695090077</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The type of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Metric</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d9bd488f6dd42d294495fb780858e83d</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The description of the dataset.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the tag system that corresponds to the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a191ae4ca615b0ccb93c211fc8a998af</para>
        /// </summary>
        [NameInMap("labelId")]
        [Validation(Required=false)]
        public string LabelId { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1695090077</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls_builtin_dataset_metric.shapeclassification.anomalydetection</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration type of the tag table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Metric.ShapeClassification.AnomalyDetection</para>
        /// </summary>
        [NameInMap("settingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

    }

}
