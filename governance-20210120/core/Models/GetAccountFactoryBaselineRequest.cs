// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetAccountFactoryBaselineRequest : TeaModel {
        /// <summary>
        /// <para>The baseline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp1nf0enuzb89az*****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

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
