// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Hyperparameters : TeaModel {
        /// <summary>
        /// <para>The frequency at which the model configuration is saved. If you set this parameter to 1, model configuration is saved every epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public long? BackupInterval { get; set; }

        /// <summary>
        /// <para>The batch size for model training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public long? BatchSize { get; set; }

        /// <summary>
        /// <para>The number of threads used to read the training data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DataLoaderWorkers")]
        [Validation(Required=false)]
        public long? DataLoaderWorkers { get; set; }

        /// <summary>
        /// <para>The custom parameters for model training.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Evaluator")]
        [Validation(Required=false)]
        public CustomParams Evaluator { get; set; }

        /// <summary>
        /// <para>The image size. The array contains the width and height of the image.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputSize")]
        [Validation(Required=false)]
        public List<long?> InputSize { get; set; }

        /// <summary>
        /// <para>The number of epochs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxEpoch")]
        [Validation(Required=false)]
        public long? MaxEpoch { get; set; }

        /// <summary>
        /// <para>The optimization algorithm.</para>
        /// </summary>
        [NameInMap("Optimization")]
        [Validation(Required=false)]
        public Optimization Optimization { get; set; }

        /// <summary>
        /// <para>The learning rate scheduler.</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
