// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAddonReleaseRequest : TeaModel {
        /// <summary>
        /// <para>The Addon name of the component that needs to be monitored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-gpu</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>The language type of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>Whether it is a dry run, default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Field rules</para>
        /// </summary>
        [NameInMap("entityRules")]
        [Validation(Required=false)]
        public EntityDiscoverRule EntityRules { get; set; }

        /// <summary>
        /// <para>Environment type. If the Policy type is CS and ECS, use accordingly; otherwise, it is unified as Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("envType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>Parent AddonReleaseId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("parentAddonReleaseId")]
        [Validation(Required=false)]
        public string ParentAddonReleaseId { get; set; }

        /// <summary>
        /// <para>The plugin name after access. If not specified, a default rule name will be generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-gpu-integration-name</para>
        /// </summary>
        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// <para>Input metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;install&quot;:{&quot;mode&quot;:&quot;auto-install&quot;,&quot;listenPort&quot;:&quot;9400&quot;},&quot;discoverMode&quot;:&quot;instances&quot;,&quot;discover&quot;:{&quot;instances&quot;:&quot;worker-k8s-for-cs-c126d87c76218487e83ab322017f11b44&quot;},&quot;scrapeInterval&quot;:&quot;15&quot;,&quot;enableSecuritecs-nodeyGroupInjection&quot;:&quot;true&quot;,&quot;metricTags&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

        /// <summary>
        /// <para>The version of the Addon component that needs to be monitored.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The workspace name for installing the component resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
