// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class JoinVSwitchesToEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the edge network instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-xxxx</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The information about the internal networking to which you want to add the edge network instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;},{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;}]</para>
        /// </summary>
        [NameInMap("VSwitchesInfo")]
        [Validation(Required=false)]
        public string VSwitchesInfo { get; set; }

    }

}
