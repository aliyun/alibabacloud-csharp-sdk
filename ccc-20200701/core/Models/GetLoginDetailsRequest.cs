// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetLoginDetailsRequest : TeaModel {
        /// <summary>
        /// <para>Chat Device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c51c9116c36537cb850dc1081d745df</para>
        /// </summary>
        [NameInMap("ChatDeviceId")]
        [Validation(Required=false)]
        public string ChatDeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Agent ID. This parameter is optional. If not specified, the agent mapped to the current RAM account is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
