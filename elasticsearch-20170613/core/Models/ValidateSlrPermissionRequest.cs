// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ValidateSlrPermissionRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token used to ensure the idempotence of the request. The value must be unique across different requests and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the service-linked role. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- AliyunServiceRoleForElasticsearchOps: used to perform elastic scaling tasks for clusters- AliyunServiceRoleForElasticsearchCollector: used to create and manage Beats collectors</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForElasticsearchCollector</para>
        /// </summary>
        [NameInMap("rolename")]
        [Validation(Required=false)]
        public string Rolename { get; set; }

    }

}
