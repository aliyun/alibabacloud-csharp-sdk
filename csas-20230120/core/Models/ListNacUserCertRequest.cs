// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListNacUserCertRequest : TeaModel {
        /// <summary>
        /// <para>Page number of the current page in a paged query. Valid values: 1 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Department that the user belongs to. The value must be 1 to 128 characters in length. It can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), commas (,), semicolons (;), hyphens (-), underscores (_), forward slashes (/), at signs (@), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>Operating system type of the endpoint device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>windows</b>: Windows.</para>
        /// </description></item>
        /// <item><description><para><b>macos</b>: macOS.</para>
        /// </description></item>
        /// <item><description><para><b>linux</b>: Linux.</para>
        /// </description></item>
        /// <item><description><para><b>android</b>: Android.</para>
        /// </description></item>
        /// <item><description><para><b>ios</b>: iOS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>End time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1702770400</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Number of entries per page for a paged query. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1702260834</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Certificate status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang**</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
