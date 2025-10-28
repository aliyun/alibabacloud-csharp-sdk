// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AddLogPathRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-4413**********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The absolute path of the log directory that you want to add. The value must start and end with a forward slash (<c>/</c>) and must contain <c>/log</c> or <c>/logs</c>. The following directories are the default log directories in Enterprise Distributed Application Service (EDAS):</para>
        /// <list type="bullet">
        /// <item><description>/home/admin/edas-container/logs/</description></item>
        /// <item><description>/home/admin/taobao-tomcat-7.0.59/logs/</description></item>
        /// <item><description>/home/admin/taobao-tomcat-production-7.0.59.3/logs/</description></item>
        /// <item><description>/home/admin/taobao-tomcat-production-7.0.70/logs/</description></item>
        /// <item><description>/home/admin/edas-agent/logs/</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/temp/log/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
