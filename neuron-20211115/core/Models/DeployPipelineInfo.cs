// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class DeployPipelineInfo : TeaModel {
        [NameInMap("deployInstanceInfos")]
        [Validation(Required=false)]
        public List<DeployInstanceInfo> DeployInstanceInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>528f9a66-cbe3-4cd8-91c0-bc4260a13d87</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Batch 1 Change</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
