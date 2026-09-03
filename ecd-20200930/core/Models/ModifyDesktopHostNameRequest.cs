// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopHostNameRequest : TeaModel {
        /// <summary>
        /// <para>The cloud desktop ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop IDs.</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The new hostname of the cloud desktop. The hostname must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The hostname must be 2 to 15 characters in length.</description></item>
        /// <item><description>The hostname can contain uppercase letters, lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen, cannot contain consecutive hyphens, and cannot contain only digits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewName</para>
        /// </summary>
        [NameInMap("NewHostName")]
        [Validation(Required=false)]
        public string NewHostName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
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
