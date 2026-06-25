// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DataImageRegionDistributeMapValue : TeaModel {
        /// <summary>
        /// <para>The distribution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("DistributeStatus")]
        [Validation(Required=false)]
        public string DistributeStatus { get; set; }

        /// <summary>
        /// <para>The distribution progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100%</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

    }

}
