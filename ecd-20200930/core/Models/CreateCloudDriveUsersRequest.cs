// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveUsersRequest : TeaModel {
        /// <summary>
        /// <para>Enterprise cloud drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-352282****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>List of end user IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to obtain a list of regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Maximum storage size for a user\&quot;s personal cloud drive. This value must not exceed the remaining available capacity in the enterprise cloud drive. Unit: byte.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>209715200</para>
        /// </summary>
        [NameInMap("UserMaxSize")]
        [Validation(Required=false)]
        public long? UserMaxSize { get; set; }

    }

}
