// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class DeleteAxgGroupRequest : TeaModel {
        /// <summary>
        /// <para>The G group ID (GID).</para>
        /// <list type="bullet">
        /// <item><description><para>Log on to the Phone Number Privacy Protection console. On the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page, filter for number pools of the <b>AXG Privacy Number</b> type and click <b>G Number Group Management</b> to view the IDs of all G groups.</para>
        /// </description></item>
        /// <item><description><para>If you created the G group by calling the <a href="https://help.aliyun.com/document_detail/110250.html">CreateAxgGroup</a> API, use the returned <b>GroupID</b> as the value for this <b>GroupId</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200001234****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>You can obtain the <b>key of the number pool</b> on the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page in the Phone Number Privacy Protection console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2235****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
