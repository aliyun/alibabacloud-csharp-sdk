// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListBuildPackResponseBody : TeaModel {
        [NameInMap("BuildPackList")]
        [Validation(Required=false)]
        public ListBuildPackResponseBodyBuildPackList BuildPackList { get; set; }
        public class ListBuildPackResponseBodyBuildPackList : TeaModel {
            [NameInMap("BuildPack")]
            [Validation(Required=false)]
            public List<ListBuildPackResponseBodyBuildPackListBuildPack> BuildPack { get; set; }
            public class ListBuildPackResponseBodyBuildPackListBuildPack : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("MultipleTenant")]
                [Validation(Required=false)]
                public bool? MultipleTenant { get; set; }

                [NameInMap("PackVersion")]
                [Validation(Required=false)]
                public string PackVersion { get; set; }

                [NameInMap("PandoraDesc")]
                [Validation(Required=false)]
                public string PandoraDesc { get; set; }

                [NameInMap("PandoraDownloadUrl")]
                [Validation(Required=false)]
                public string PandoraDownloadUrl { get; set; }

                [NameInMap("PandoraVersion")]
                [Validation(Required=false)]
                public string PandoraVersion { get; set; }

                [NameInMap("PluginInfo")]
                [Validation(Required=false)]
                public string PluginInfo { get; set; }

                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

                [NameInMap("SupportFeatures")]
                [Validation(Required=false)]
                public string SupportFeatures { get; set; }

                [NameInMap("TengineDownloadUrl")]
                [Validation(Required=false)]
                public string TengineDownloadUrl { get; set; }

                [NameInMap("TengineImageId")]
                [Validation(Required=false)]
                public string TengineImageId { get; set; }

                [NameInMap("TomcatDesc")]
                [Validation(Required=false)]
                public string TomcatDesc { get; set; }

                [NameInMap("TomcatDownloadUrl")]
                [Validation(Required=false)]
                public string TomcatDownloadUrl { get; set; }

                [NameInMap("TomcatPath")]
                [Validation(Required=false)]
                public string TomcatPath { get; set; }

                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

                [NameInMap("WithTengine")]
                [Validation(Required=false)]
                public bool? WithTengine { get; set; }

            }

        }

        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD4-*************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
