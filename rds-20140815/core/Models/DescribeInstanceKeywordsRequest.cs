// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceKeywordsRequest : TeaModel {
        /// <summary>
        /// <para>The type of reserved keyword to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>account</b></description></item>
        /// <item><description><b>database</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>account</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
