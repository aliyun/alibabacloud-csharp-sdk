// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CancelCoordinationForMonitoringRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of stream collaboration tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CoIds")]
        [Validation(Required=false)]
        public List<string> CoIds { get; set; }

        /// <summary>
        /// <para>The ID of the end user that initiates stream collaboration. If the initiator is the administrator, skip this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/436773.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the user.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>TENANT_ADMIN: administrator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT_ADMIN</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
