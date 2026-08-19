// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. This is the value of the AppId parameter returned by the <a href="https://help.aliyun.com/document_detail/113266.html">CreateApp</a> or <a href="https://help.aliyun.com/document_detail/114000.html">GetAppInfos</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The new application name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 characters in length and can contain Chinese characters, letters, digits, periods (.), hyphens (-), and at signs (@).</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The new application description.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 512 characters in length.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>my first app.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new application status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
