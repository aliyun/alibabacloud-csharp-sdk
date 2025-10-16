// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclRuleCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InternetInAclCount")]
        [Validation(Required=false)]
        public int? InternetInAclCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InternetOutAclCount")]
        [Validation(Required=false)]
        public int? InternetOutAclCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NatInAclCount")]
        [Validation(Required=false)]
        public int? NatInAclCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NatOutAclCount")]
        [Validation(Required=false)]
        public int? NatOutAclCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27936D6C-1B7A-5A5A-B9E4-FBEBBDAA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalAclCount")]
        [Validation(Required=false)]
        public int? TotalAclCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("VpcAclCount")]
        [Validation(Required=false)]
        public int? VpcAclCount { get; set; }

    }

}
