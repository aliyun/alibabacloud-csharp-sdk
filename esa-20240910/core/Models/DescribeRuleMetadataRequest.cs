// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRuleMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the metadata.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa_condition_region_config_en</para>
        /// </summary>
        [NameInMap("MetaName")]
        [Validation(Required=false)]
        public string MetaName { get; set; }

    }

}
