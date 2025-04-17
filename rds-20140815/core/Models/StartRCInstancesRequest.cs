// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StartRCInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation mode. Set the value to <b>AllTogether</b>. In this mode, a success message is returned if all specified instances are started. If an instance fails the verification, none of the specified instances can be started and an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllTogether</para>
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// <para>The node IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
