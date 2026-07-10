// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyControlStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of security alert rules.</para>
        /// </summary>
        [NameInMap("ControlStrategyList")]
        [Validation(Required=false)]
        public string ControlStrategyListShrink { get; set; }

        /// <summary>
        /// <para>The product type. Currently, only <b>ANT_CLOUD_AUTH</b> (financial-grade ID Verification) is supported. All other types have been discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
