// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyRefreshProcessInfoRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the server.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0f3b8f76-90e5-4455-a5aa-23ce30b5****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
