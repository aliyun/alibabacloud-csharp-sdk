// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateContainerConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c627c157-560d-43ff-************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The context path of the Tomcat container. The context path can be an empty string, a null WAR package name, a root directory, or other custom non-empty strings. It can contain letters, digits, hyphens (-), and underscores (_). Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.</description></item>
        /// <item><description>If this parameter is not specified when you configure the Tomcat container for an application, the root directory <c>/</c> is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("ContextPath")]
        [Validation(Required=false)]
        public string ContextPath { get; set; }

        /// <summary>
        /// <para>The ID of the application instance group.</para>
        /// <list type="bullet">
        /// <item><description>If an ID is specified, this operation configures the Tomcat container for the specified application instance group.</description></item>
        /// <item><description>If you set this parameter to &quot;&quot;, this operation configures the Tomcat container for the application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-**************</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The application port number for the Tomcat container. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.</description></item>
        /// <item><description>If this parameter is not specified when you configure the application, the default port 8080 is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// <para>The maximum number of threads. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.</description></item>
        /// <item><description>If this parameter is not specified when you configure the application, the default value 250 is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxThreads")]
        [Validation(Required=false)]
        public int? MaxThreads { get; set; }

        /// <summary>
        /// <para>The uniform resource identifier (URI) encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.</description></item>
        /// <item><description>If this parameter is not specified when you configure the application, the default URI encoding scheme in the Tomcat container is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ISO-8859-1</para>
        /// </summary>
        [NameInMap("URIEncoding")]
        [Validation(Required=false)]
        public string URIEncoding { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the encoding scheme specified in the request body for URI query parameters. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.</description></item>
        /// <item><description>If this parameter is not specified when you configure the application, the default value false is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

    }

}
