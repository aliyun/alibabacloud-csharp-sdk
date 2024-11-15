// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class CreateAccountFactoryBaselineRequest : TeaModel {
        /// <summary>
        /// <para>The baseline items.</para>
        /// <para>You can call the <a href="~~ListAccountFactoryBaselineItems~~">ListAccountFactoryBaselineItems</a> operation to query a list of baseline items supported by the account factory in Cloud Governance Center.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<CreateAccountFactoryBaselineRequestBaselineItems> BaselineItems { get; set; }
        public class CreateAccountFactoryBaselineRequestBaselineItems : TeaModel {
            /// <summary>
            /// <para>The configurations of the baseline item. The value of this parameter is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;EnabledServices\&quot;:[\&quot;CEN_TR\&quot;,\&quot;CDT\&quot;,\&quot;CMS\&quot;,\&quot;KMS\&quot;]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The name of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// <para>The description of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default Baseline.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
