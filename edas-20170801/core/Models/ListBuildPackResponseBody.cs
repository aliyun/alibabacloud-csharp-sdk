// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListBuildPackResponseBody : TeaModel {
        /// <summary>
        /// The returned versions of EDAS Container.
        /// </summary>
        [NameInMap("BuildPackList")]
        [Validation(Required=false)]
        public ListBuildPackResponseBodyBuildPackList BuildPackList { get; set; }
        public class ListBuildPackResponseBodyBuildPackList : TeaModel {
            [NameInMap("BuildPack")]
            [Validation(Required=false)]
            public List<ListBuildPackResponseBodyBuildPackListBuildPack> BuildPack { get; set; }
            public class ListBuildPackResponseBodyBuildPackListBuildPack : TeaModel {
                /// <summary>
                /// The build package number of EDAS Container.
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// Indicates whether the EDAS Container version is disabled. A disabled version cannot be configured for use.
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// The features of the EDAS Container version, which are released for public preview.
                /// </summary>
                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                /// <summary>
                /// The ID of the base image that corresponds to EDAS Container.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// Indicates whether EDAS Container supports multitenancy.
                /// </summary>
                [NameInMap("MultipleTenant")]
                [Validation(Required=false)]
                public bool? MultipleTenant { get; set; }

                /// <summary>
                /// The version of the application.
                /// </summary>
                [NameInMap("PackVersion")]
                [Validation(Required=false)]
                public string PackVersion { get; set; }

                /// <summary>
                /// The description of the Pandora container.
                /// </summary>
                [NameInMap("PandoraDesc")]
                [Validation(Required=false)]
                public string PandoraDesc { get; set; }

                /// <summary>
                /// The download URL of the Pandora installer.
                /// </summary>
                [NameInMap("PandoraDownloadUrl")]
                [Validation(Required=false)]
                public string PandoraDownloadUrl { get; set; }

                /// <summary>
                /// The version of the Pandora container.
                /// </summary>
                [NameInMap("PandoraVersion")]
                [Validation(Required=false)]
                public string PandoraVersion { get; set; }

                /// <summary>
                /// The description of the plug-in.
                /// </summary>
                [NameInMap("PluginInfo")]
                [Validation(Required=false)]
                public string PluginInfo { get; set; }

                /// <summary>
                /// The name of the Shell script that runs EDAS Container.
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// The version of the Shell script that runs EDAS Container.
                /// </summary>
                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

                /// <summary>
                /// The features supported by EDAS Container.
                /// </summary>
                [NameInMap("SupportFeatures")]
                [Validation(Required=false)]
                public string SupportFeatures { get; set; }

                /// <summary>
                /// The download URL of the Tengine installer.
                /// </summary>
                [NameInMap("TengineDownloadUrl")]
                [Validation(Required=false)]
                public string TengineDownloadUrl { get; set; }

                /// <summary>
                /// The ID of the Tengine image that corresponds to EDAS Container.
                /// </summary>
                [NameInMap("TengineImageId")]
                [Validation(Required=false)]
                public string TengineImageId { get; set; }

                /// <summary>
                /// The description of the Tomcat container.
                /// </summary>
                [NameInMap("TomcatDesc")]
                [Validation(Required=false)]
                public string TomcatDesc { get; set; }

                /// <summary>
                /// The download URL of the Tomcat installer.
                /// </summary>
                [NameInMap("TomcatDownloadUrl")]
                [Validation(Required=false)]
                public string TomcatDownloadUrl { get; set; }

                /// <summary>
                /// The directory of the Tomcat container.
                /// </summary>
                [NameInMap("TomcatPath")]
                [Validation(Required=false)]
                public string TomcatPath { get; set; }

                /// <summary>
                /// The version of the Tomcat container.
                /// </summary>
                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

                /// <summary>
                /// Indicates whether EDAS Container supports traffic management.
                /// </summary>
                [NameInMap("WithTengine")]
                [Validation(Required=false)]
                public bool? WithTengine { get; set; }

            }

        }

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
