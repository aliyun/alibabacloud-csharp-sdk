// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xgboost数据集加速实例</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxSlot")]
        [Validation(Required=false)]
        public string MaxSlot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acc_instance_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
