// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration set information.</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public ConfigSetDetailResponseBodyDetail Detail { get; set; }
        public class ConfigSetDetailResponseBodyDetail : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configuration set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The associated IP pool.</para>
            /// </summary>
            [NameInMap("IpPool")]
            [Validation(Required=false)]
            public ConfigSetDetailResponseBodyDetailIpPool IpPool { get; set; }
            public class ConfigSetDetailResponseBodyDetailIpPool : TeaModel {
                /// <summary>
                /// <para>The associated IP pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolId")]
                [Validation(Required=false)]
                public string IpPoolId { get; set; }

                /// <summary>
                /// <para>The associated IP pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolName")]
                [Validation(Required=false)]
                public string IpPoolName { get; set; }

            }

            [NameInMap("IsPublicChannelBackoff")]
            [Validation(Required=false)]
            public bool? IsPublicChannelBackoff { get; set; }

            /// <summary>
            /// <para>The configuration set name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ValidationOption")]
            [Validation(Required=false)]
            public ConfigSetDetailResponseBodyDetailValidationOption ValidationOption { get; set; }
            public class ConfigSetDetailResponseBodyDetailValidationOption : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("ForbiddenStatusList")]
                [Validation(Required=false)]
                public List<string> ForbiddenStatusList { get; set; }

                [NameInMap("ForbiddenSubStatusList")]
                [Validation(Required=false)]
                public List<string> ForbiddenSubStatusList { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
