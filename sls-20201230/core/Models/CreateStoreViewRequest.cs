// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateStoreViewRequest : TeaModel {
        /// <summary>
        /// The name of the dataset.
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (_).
        /// *   The name must start with a lowercase letter.
        /// *   The name must be 3 to 62 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the dataset. Valid values: metricstore and logstore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        /// <summary>
        /// The Logstores or Metricstores.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<StoreViewStore> Stores { get; set; }

    }

}
