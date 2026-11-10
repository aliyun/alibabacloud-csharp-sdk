// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ModifyUserPolicyBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deveoper-policy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-89unlabdl****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
