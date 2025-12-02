// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsForSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group. You can call the <a href="https://help.aliyun.com/document_detail/126249.html">DescribeApplicationGroups</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of a namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The canary tag</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;alicloud.service.tag&quot;:&quot;gray&quot;}</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
