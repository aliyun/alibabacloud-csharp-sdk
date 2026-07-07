// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RefreshAuthTokensRequest : TeaModel {
        /// <summary>
        /// <para>The validity period in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public long? ExpireSeconds { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp-2zef0gov2nh2l3xxx,acp-2zef0gov2nh2l3yyy</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The list of license keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lk-abcdef1234567890,lk-abcdef1234567891</para>
        /// </summary>
        [NameInMap("LicenseKeys")]
        [Validation(Required=false)]
        public string LicenseKeys { get; set; }

    }

}
