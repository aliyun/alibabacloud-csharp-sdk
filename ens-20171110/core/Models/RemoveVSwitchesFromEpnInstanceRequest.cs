// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveVSwitchesFromEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of theEPN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-****</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The internal networking information that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VSwitchesInfo=[{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;},{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;}]</para>
        /// </summary>
        [NameInMap("VSwitchesInfo")]
        [Validation(Required=false)]
        public string VSwitchesInfo { get; set; }

    }

}
