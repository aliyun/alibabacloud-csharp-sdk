// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateContainerConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The context path of the Tomcat container. The context path can be an empty string, a null WAR package name, a root directory, or other custom non-empty strings. It can contain letters, digits, hyphens (-), and underscores (\_). Take note of the following items:
        /// 
        /// *   If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.
        /// *   If this parameter is not specified when you configure the Tomcat container for an application, the root directory `/` is used.
        /// </summary>
        [NameInMap("ContextPath")]
        [Validation(Required=false)]
        public string ContextPath { get; set; }

        /// <summary>
        /// The ID of the application instance group.
        /// 
        /// *   If an ID is specified, this operation configures the Tomcat container for the specified application instance group.
        /// *   If you set this parameter to "", this operation configures the Tomcat container for the application.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The application port number for the Tomcat container. Take note of the following items:
        /// 
        /// *   If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.
        /// *   If this parameter is not specified when you configure the application, the default port 8080 is applied.
        /// </summary>
        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// The maximum number of threads. Take note of the following items:
        /// 
        /// *   If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.
        /// *   If this parameter is not specified when you configure the application, the default value 250 is applied.
        /// </summary>
        [NameInMap("MaxThreads")]
        [Validation(Required=false)]
        public int? MaxThreads { get; set; }

        /// <summary>
        /// The uniform resource identifier (URI) encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8. Take note of the following items:
        /// 
        /// *   If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.
        /// *   If this parameter is not specified when you configure the application, the default URI encoding scheme in the Tomcat container is applied.
        /// </summary>
        [NameInMap("URIEncoding")]
        [Validation(Required=false)]
        public string URIEncoding { get; set; }

        /// <summary>
        /// Specifies whether to use the encoding scheme specified in the request body for URI query parameters. Take note of the following items:
        /// 
        /// *   If this parameter is not specified when you configure the application instance group, the configuration of the application is applied.
        /// *   If this parameter is not specified when you configure the application, the default value false is applied.
        /// </summary>
        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

    }

}
