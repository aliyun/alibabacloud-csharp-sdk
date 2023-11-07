// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class UpdateGlobalEventsStorageRegionRequest : TeaModel {
        /// <summary>
        /// The region where you want to store global events.
        /// 
        /// Valid values:
        /// 
        /// *   ap-southeast-1
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     the Singapore region
        /// 
        ///     <!-- -->
        /// 
        /// *   cn-hangzhou
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     the China (Hangzhou) region
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

    }

}
