// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrainingSpecification : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelSpecification")]
        [Validation(Required=false)]
        public ModelSpecification ModelSpecification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/cifar10/test_index.json</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/model_training_test/</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CustomParams> Transforms { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://imm-alg-dataset-bj/cifar10/test_index.json</para>
        /// </summary>
        [NameInMap("ValidationSourceURI")]
        [Validation(Required=false)]
        public string ValidationSourceURI { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.95</para>
        /// </summary>
        [NameInMap("ValidationSplit")]
        [Validation(Required=false)]
        public float? ValidationSplit { get; set; }

    }

}
