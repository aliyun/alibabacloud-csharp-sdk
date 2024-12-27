// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Hyperparameters : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public long? BackupInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public long? BatchSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DataLoaderWorkers")]
        [Validation(Required=false)]
        public long? DataLoaderWorkers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Evaluator")]
        [Validation(Required=false)]
        public CustomParams Evaluator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputSize")]
        [Validation(Required=false)]
        public List<long?> InputSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxEpoch")]
        [Validation(Required=false)]
        public long? MaxEpoch { get; set; }

        [NameInMap("Optimization")]
        [Validation(Required=false)]
        public Optimization Optimization { get; set; }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
