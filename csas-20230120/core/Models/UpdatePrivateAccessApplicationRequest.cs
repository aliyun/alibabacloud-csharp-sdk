// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationRequest : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("L7Config")]
        [Validation(Required=false)]
        public PAL7Config L7Config { get; set; }

        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        [NameInMap("L7ProxyDomainCustom")]
        [Validation(Required=false)]
        public string L7ProxyDomainCustom { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("L7ProxyDomainPrivate")]
        [Validation(Required=false)]
        [Obsolete]
        public string L7ProxyDomainPrivate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationRequestPortRanges : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
