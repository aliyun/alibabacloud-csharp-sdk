// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveContactWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The contact whitelist. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ContactWhiteListList")]
        [Validation(Required=false)]
        public List<string> ContactWhiteListList { get; set; }

        /// <summary>
        /// <para>The whitelist. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;phoneNumber&quot;:&quot;132322&quot;,&quot;remark&quot;:&quot;123321&quot;,&quot;name&quot;:&quot;ccc1&quot;,&quot;creator&quot;:&quot;ccc222&quot;}]</para>
        /// </summary>
        [NameInMap("ContactWhiteListsJson")]
        [Validation(Required=false)]
        public string ContactWhiteListsJson { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c415bb6c-2e6f-46aa-afd9-3b65b6dbe2bc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
