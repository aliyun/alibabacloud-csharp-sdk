// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAvailableModelsRequest : TeaModel {
        /// <summary>
        /// <para>aideploy</para>
        /// 
        /// <b>Example:</b>
        /// <para>aideploy</para>
        /// </summary>
        [NameInMap("KubeType")]
        [Validation(Required=false)]
        public string KubeType { get; set; }

        /// <summary>
        /// <para>The model type. Valid values: custom or public. If this parameter is not specified, all models are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
