// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class DescribeVerifySchemeRequest : TeaModel {
        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public long? CustomerId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000010643****</para>
        /// </summary>
        [NameInMap("SchemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

    }

}
