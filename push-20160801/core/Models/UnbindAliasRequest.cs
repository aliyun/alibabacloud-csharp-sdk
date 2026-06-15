// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class UnbindAliasRequest : TeaModel {
        /// <summary>
        /// <para>The alias to detach.</para>
        /// <para>An alias supports up to 128 bytes (one Chinese character counts as 3 bytes). This field is required when UnbindAll is false. You can detach up to 10 aliases at once. Separate multiple aliases with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_alias</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The unique device identifier for push notifications. It is 32 characters long and consists of digits and lowercase letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2ba19de97604f55b16557673****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Whether to detach all aliases. Default is false.</para>
        /// <para>If true, detaches all aliases currently bound to the device. If false, detaches only the aliases specified in AliasName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UnbindAll")]
        [Validation(Required=false)]
        public bool? UnbindAll { get; set; }

    }

}
