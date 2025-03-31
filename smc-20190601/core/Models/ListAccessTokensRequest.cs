// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ListAccessTokensRequest : TeaModel {
        /// <summary>
        /// <para>The information about activation codes.</para>
        /// </summary>
        [NameInMap("AccessTokenId")]
        [Validation(Required=false)]
        public List<string> AccessTokenId { get; set; }

        /// <summary>
        /// <para>The name of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The status of the activation code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>activated</description></item>
        /// <item><description>unactivated</description></item>
        /// <item><description>expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>activated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
