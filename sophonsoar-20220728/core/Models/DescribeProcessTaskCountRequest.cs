// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTaskCountRequest : TeaModel {
        /// <summary>
        /// <para>Collection of entity UUIDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EntityUuidList")]
        [Validation(Required=false)]
        public List<string> EntityUuidList { get; set; }

        /// <summary>
        /// <para>Language type for request and response messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>User ID for administrators to switch to other member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104739******259</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>View type.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Current Alibaba Cloud account view.</description></item>
        /// <item><description><b>1</b>: View for all accounts under the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
