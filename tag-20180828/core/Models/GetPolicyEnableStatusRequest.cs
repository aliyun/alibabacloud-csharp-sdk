// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyEnableStatusRequest : TeaModel {
        /// <summary>
        /// <para>The enabling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TAG_POLICY: the Tag Policy feature.</description></item>
        /// <item><description>VERIFY_NO_TAG: the strong verification feature.</description></item>
        /// <item><description>TAG_POLICY_NOTIFY: the notification feature that sends notifications for resources found to be non-compliant with the tag policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TAG_POLICY</para>
        /// </summary>
        [NameInMap("OpenType")]
        [Validation(Required=false)]
        public string OpenType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The mode of the Tag Policy feature. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: single-account mode</description></item>
        /// <item><description>RD: multi-account mode</description></item>
        /// </list>
        /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
        /// <remarks>
        /// <para> The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RD</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
