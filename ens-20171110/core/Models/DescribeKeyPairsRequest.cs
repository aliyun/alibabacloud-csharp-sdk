// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeKeyPairsRequest : TeaModel {
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// The name of the key pair. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain the following characters:
        /// 
        /// *   Digits
        /// *   :
        /// *   \_
        /// *   *
        /// 
        /// You can specify only one name. By default, all key pairs are queried.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The page number of the returned page. Valid values: integers that are greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: integers that are greater than 0. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
