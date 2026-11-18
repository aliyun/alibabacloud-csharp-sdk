// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can obtain the value from the AppId parameter returned by the <a href="https://help.aliyun.com/document_detail/113266.html">Create an application</a> or <a href="https://help.aliyun.com/document_detail/114000.html">List applications</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The new name of the application.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 128 characters in length and can contain only Chinese characters, uppercase and lowercase letters, digits, periods (.), hyphens (-), and at signs (@).</description></item>
        /// <item><description>The name must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The new description of the application.</para>
        /// <list type="bullet">
        /// <item><description>The description can be up to 512 characters in length.</description></item>
        /// <item><description>The description must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>my first app.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new status of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Enabled.</description></item>
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
