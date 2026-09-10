// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAddonReleaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the addon component to be connected to monitoring.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The field rules.</para>
        /// </summary>
        [NameInMap("entityRules")]
        [Validation(Required=false)]
        public EntityDiscoverRule EntityRules { get; set; }

        /// <summary>
        /// <para>The environment type. If the policy type is CS or ECS, the corresponding value is used. For other types, the value is Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("envType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The parent AddonReleaseId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("parentAddonReleaseId")]
        [Validation(Required=false)]
        public string ParentAddonReleaseId { get; set; }

        /// <summary>
        /// <para>The name of the plugin after access. If this parameter is not specified, a default rule name is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-gpu-integration-name</para>
        /// </summary>
        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// <para>The input metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;install&quot;:{&quot;mode&quot;:&quot;auto-install&quot;,&quot;listenPort&quot;:&quot;9400&quot;},&quot;discoverMode&quot;:&quot;instances&quot;,&quot;discover&quot;:{&quot;instances&quot;:&quot;worker-k8s-for-cs-c126d87c76218487e83ab322017f11b44&quot;},&quot;scrapeInterval&quot;:&quot;15&quot;,&quot;enableSecuritecs-nodeyGroupInjection&quot;:&quot;true&quot;,&quot;metricTags&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

        /// <summary>
        /// <para>The version of the addon component to be connected to monitoring.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The name of the workspace where the component resources are installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
