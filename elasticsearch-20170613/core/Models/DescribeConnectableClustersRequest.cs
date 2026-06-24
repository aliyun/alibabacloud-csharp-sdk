// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return instances that are already connected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): The returned instance list includes instances that are already connected.</description></item>
        /// <item><description>false: The returned instance list does not include instances that are already connected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alreadySetItems")]
        [Validation(Required=false)]
        public bool? AlreadySetItems { get; set; }

    }

}
