// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DatasetConfig : TeaModel {
        /// <summary>
        /// <para>The content awareness configuration.</para>
        /// </summary>
        [NameInMap("Insights")]
        [Validation(Required=false)]
        public InsightsConfig Insights { get; set; }

        [NameInMap("ReverseImage")]
        [Validation(Required=false)]
        public ReverseImageConfig ReverseImage { get; set; }

        /// <summary>
        /// <para>The intelligent clustering configuration.</para>
        /// </summary>
        [NameInMap("SmartCluster")]
        [Validation(Required=false)]
        public SmartClusterConfig SmartCluster { get; set; }

    }

}
