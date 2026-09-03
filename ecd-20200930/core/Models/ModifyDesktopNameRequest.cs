// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopNameRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The list of cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The new name of the cloud computer. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name cannot exceed 64 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), or hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DemoComputer01</para>
        /// </summary>
        [NameInMap("NewDesktopName")]
        [Validation(Required=false)]
        public string NewDesktopName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user assignment mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

    }

}
