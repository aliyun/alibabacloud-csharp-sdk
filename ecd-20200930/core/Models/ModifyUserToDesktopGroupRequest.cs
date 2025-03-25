// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserToDesktopGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud computer share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the end users that you want to add. You can configure 1 to 500 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NewEndUserIds")]
        [Validation(Required=false)]
        public List<string> NewEndUserIds { get; set; }

        /// <summary>
        /// <para>The IDs of the end users that you want to remove. You can configure 1 to 500 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OldEndUserIds")]
        [Validation(Required=false)]
        public List<string> OldEndUserIds { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
