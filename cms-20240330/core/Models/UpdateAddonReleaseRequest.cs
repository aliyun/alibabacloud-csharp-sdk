// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAddonReleaseRequest : TeaModel {
        /// <summary>
        /// <para>The version of the add-on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.2</para>
        /// </summary>
        [NameInMap("addonVersion")]
        [Validation(Required=false)]
        public string AddonVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The entity discovery rules.</para>
        /// </summary>
        [NameInMap("entityRules")]
        [Validation(Required=false)]
        public EntityDiscoverRule EntityRules { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;install&quot;:{&quot;mode&quot;:&quot;auto-install&quot;,&quot;listenPort&quot;:&quot;9400&quot;},&quot;discoverMode&quot;:&quot;instances&quot;,&quot;discover&quot;:{&quot;instances&quot;:&quot;worker-k8s-for-cs-c126d87c76218487e83ab322017f11b44&quot;},&quot;scrapeInterval&quot;:&quot;15&quot;,&quot;enableSecuritecs-nodeyGroupInjection&quot;:&quot;true&quot;,&quot;metricTags&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

    }

}
