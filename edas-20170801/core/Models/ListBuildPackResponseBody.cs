// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListBuildPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned versions of EDAS Container.</para>
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
                /// <para>The build package number of EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                /// <summary>
                /// <para>Indicates whether the EDAS Container version is disabled. A disabled version cannot be configured for use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The features of the EDAS Container version, which are released for public preview.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                /// <summary>
                /// <para>The ID of the base image that corresponds to EDAS Container.</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>Indicates whether EDAS Container supports multitenancy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MultipleTenant")]
                [Validation(Required=false)]
                public bool? MultipleTenant { get; set; }

                /// <summary>
                /// <para>The version of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.5.6</para>
                /// </summary>
                [NameInMap("PackVersion")]
                [Validation(Required=false)]
                public string PackVersion { get; set; }

                /// <summary>
                /// <para>The description of the Pandora container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("PandoraDesc")]
                [Validation(Required=false)]
                public string PandoraDesc { get; set; }

                /// <summary>
                /// <para>The download URL of the Pandora installer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://edas.oss-cn-hangzhou.aliyuncs.com/edas-plugins/edas.sar.V3.5.6/taobao-hsf.tgz">http://edas.oss-cn-hangzhou.aliyuncs.com/edas-plugins/edas.sar.V3.5.6/taobao-hsf.tgz</a></para>
                /// </summary>
                [NameInMap("PandoraDownloadUrl")]
                [Validation(Required=false)]
                public string PandoraDownloadUrl { get; set; }

                /// <summary>
                /// <para>The version of the Pandora container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas.public.sar.V3.5.6</para>
                /// </summary>
                [NameInMap("PandoraVersion")]
                [Validation(Required=false)]
                public string PandoraVersion { get; set; }

                /// <summary>
                /// <para>The description of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PluginInfo")]
                [Validation(Required=false)]
                public string PluginInfo { get; set; }

                /// <summary>
                /// <para>The name of the Shell script that runs EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The version of the Shell script that runs EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.3</para>
                /// </summary>
                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

                /// <summary>
                /// <para>The features supported by EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tengine,fatjar,restful,eip_nodeport,dpath</para>
                /// </summary>
                [NameInMap("SupportFeatures")]
                [Validation(Required=false)]
                public string SupportFeatures { get; set; }

                /// <summary>
                /// <para>The download URL of the Tengine installer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://edas.oss-cn-hangzhou.aliyuncs.com/components/tengine/3.4.7/tengine.sh">http://edas.oss-cn-hangzhou.aliyuncs.com/components/tengine/3.4.7/tengine.sh</a></para>
                /// </summary>
                [NameInMap("TengineDownloadUrl")]
                [Validation(Required=false)]
                public string TengineDownloadUrl { get; set; }

                /// <summary>
                /// <para>The ID of the Tengine image that corresponds to EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.aliyuncs.com/edas/<b><b>-</b></b><em><b><b>-</b></b></em>:<em>.</em>.*</para>
                /// </summary>
                [NameInMap("TengineImageId")]
                [Validation(Required=false)]
                public string TengineImageId { get; set; }

                /// <summary>
                /// <para>The description of the Tomcat container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1\. The config-client plug-in is updated. The issue of unread cache in multitenancy scenarios is fixed. 2. The High-Speed Service Framework (HSF) plug-in is updated to fix the issue that the qos command of the Pandora container cannot be executed and the issue that the service address cannot be found if the HSF plug-in subscribes to an excessive number of services. 3. The Fastjson package is updated to the sec06 secure version in all plug-ins that use this package.</para>
                /// </summary>
                [NameInMap("TomcatDesc")]
                [Validation(Required=false)]
                public string TomcatDesc { get; set; }

                /// <summary>
                /// <para>The download URL of the Tomcat installer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://edas.oss-cn-hangzhou.aliyuncs.com/edas-container/7.0.92/taobao-tomcat-production-7.0.92.tar.gz">http://edas.oss-cn-hangzhou.aliyuncs.com/edas-container/7.0.92/taobao-tomcat-production-7.0.92.tar.gz</a></para>
                /// </summary>
                [NameInMap("TomcatDownloadUrl")]
                [Validation(Required=false)]
                public string TomcatDownloadUrl { get; set; }

                /// <summary>
                /// <para>The directory of the Tomcat container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>taobao-tomcat-production-7.0.59.3</para>
                /// </summary>
                [NameInMap("TomcatPath")]
                [Validation(Required=false)]
                public string TomcatPath { get; set; }

                /// <summary>
                /// <para>The version of the Tomcat container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.5.63</para>
                /// </summary>
                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether EDAS Container supports traffic management.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD4-*************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
