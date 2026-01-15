// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeFeatureOptionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINANCE_51</para>
        /// </summary>
        [NameInMap("FeatureTemplate")]
        [Validation(Required=false)]
        public string FeatureTemplate { get; set; }

    }

}
