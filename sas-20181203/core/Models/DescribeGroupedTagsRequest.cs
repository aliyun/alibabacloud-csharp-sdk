// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedTagsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset to query. If you do not specify this parameter, the tags of all asset types are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: server</description></item>
        /// <item><description><b>cloud_product</b>: Alibaba Cloud service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

    }

}
