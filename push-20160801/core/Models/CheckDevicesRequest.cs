// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23419851</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The unique identifier for each device in the push service. Each ID is 32 characters long and contains only digits and lowercase letters. Separate multiple IDs with commas. You can check up to 100 devices per request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae296f3b04a58a05b30c95f****,ae296f3b04a58a05b30c95f****,ae296f3b04a58a05b30c95f****</para>
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public string DeviceIds { get; set; }

    }

}
