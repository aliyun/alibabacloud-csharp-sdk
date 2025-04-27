// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance that can communicate with each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("alreadySetItems")]
        [Validation(Required=false)]
        public bool? AlreadySetItems { get; set; }

    }

}
