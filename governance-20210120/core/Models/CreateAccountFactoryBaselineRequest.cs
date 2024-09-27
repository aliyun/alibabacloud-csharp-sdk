// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class CreateAccountFactoryBaselineRequest : TeaModel {
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<CreateAccountFactoryBaselineRequestBaselineItems> BaselineItems { get; set; }
        public class CreateAccountFactoryBaselineRequestBaselineItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;EnabledServices\&quot;:[\&quot;CEN_TR\&quot;,\&quot;CDT\&quot;,\&quot;CMS\&quot;,\&quot;KMS\&quot;]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACS-BP_ACCOUNT_FACTORY_VPC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>RegionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
