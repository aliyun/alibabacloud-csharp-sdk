// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeVersionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public DescribeVersionConfigRequestSdkRequest SdkRequest { get; set; }
        public class DescribeVersionConfigRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account of the resource folder member accounts.</para>
            /// <remarks>
            /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5815612291408486</para>
            /// </summary>
            [NameInMap("ResourceDirectoryAccountId")]
            [Validation(Required=false)]
            public long? ResourceDirectoryAccountId { get; set; }

            /// <summary>
            /// <para>The IP address of the access source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2409:8a55:3827:cb50:5ad9:d5ff:fe87:f48c</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

        }

    }

}
