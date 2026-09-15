// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMaintainWindowResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the silence policy, including the policy ID, name, description, enabled status, filterSetting, effective period configuration, creation time, and update time. workspaceFilterSetting is not returned.</para>
        /// </summary>
        [NameInMap("maintainWindow")]
        [Validation(Required=false)]
        public MaintainWindowForView MaintainWindow { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting and ticket submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
