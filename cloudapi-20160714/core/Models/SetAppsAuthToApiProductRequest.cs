// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetAppsAuthToApiProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>117b7a64a8b3f064eaa4a47ac62aac5e</para>
        /// </summary>
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        /// <summary>
        /// <para>The IDs of the applications that you want to authorize.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public List<long?> AppIds { get; set; }

        /// <summary>
        /// <para>The time (UTC) when the authorization expires. If this parameter is empty, the authorization does not expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-31T08:15:39Z</para>
        /// </summary>
        [NameInMap("AuthValidTime")]
        [Validation(Required=false)]
        public string AuthValidTime { get; set; }

        /// <summary>
        /// <para>The description of the authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
