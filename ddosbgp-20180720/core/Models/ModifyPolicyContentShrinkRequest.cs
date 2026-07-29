// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyContentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The policy content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
