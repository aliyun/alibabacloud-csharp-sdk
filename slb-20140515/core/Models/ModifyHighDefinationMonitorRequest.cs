// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyHighDefinationMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The new name of the project of Log Service. The name must be 4 to 63 characters in length, and can contain digits and lowercase letters. It must start and end with a digit or a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("LogProject")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        /// <summary>
        /// <para>The new name of the Logstore of Log Service. The name must be 2 to 64 characters in length and can contain digits, lowercase letters, hyphens (-) and underscores (_). It must start and end with a digit or a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-log-store</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
