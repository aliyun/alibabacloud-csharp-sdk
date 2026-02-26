// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrainingSpecification : TeaModel {
        /// <summary>
        /// <para>Name of the dataset</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The endpoint of the storage where the dataset is stored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://1111111111.mns.cn-hangzhou.aliyuncs.com">http://1111111111.mns.cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The model specification details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelSpecification")]
        [Validation(Required=false)]
        public ModelSpecification ModelSpecification { get; set; }

        /// <summary>
        /// <para>The information about the runtime for model training.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>URI of the dataset</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/cifar10/test_index.json</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The storage path to the model data. Only an Object Storage Service (OSS) path is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/model_training_test/</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>Local preprocessing parameters for the dataset.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CustomParams> Transforms { get; set; }

        /// <summary>
        /// <para>The URI of the evaluation dataset. You must specify this parameter or the ValidationSplit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/cifar10/test_index.json</para>
        /// </summary>
        [NameInMap("ValidationSourceURI")]
        [Validation(Required=false)]
        public string ValidationSourceURI { get; set; }

        /// <summary>
        /// <para>The ratio for splitting the training dataset into the evaluation dataset. You must specify this parameter or the ValidationSourceURI parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.95</para>
        /// </summary>
        [NameInMap("ValidationSplit")]
        [Validation(Required=false)]
        public float? ValidationSplit { get; set; }

    }

}
