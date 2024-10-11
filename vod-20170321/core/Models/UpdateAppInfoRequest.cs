// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>app-1000000</b>.</description></item>
        /// <item><description>For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain up to 128 characters in length, including Chinese letters, digits, and periods (.), dash (-), and at character (@).</description></item>
        /// <item><description>The name can contain only UTF-8 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// <list type="bullet">
        /// <item><description>The description can contain up to 512 characters in length.</description></item>
        /// <item><description>The description can contain only UTF-8 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>my first app.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The status of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>Disable</b></description></item>
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
