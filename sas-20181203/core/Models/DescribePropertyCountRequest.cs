// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprints. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **port**: port
        /// *   **process**: process
        /// *   **software**: software
        /// *   **user**: account
        /// *   **cron**: scheduled task
        /// *   **sca**: middleware
        /// *   **web**: website
        /// *   **database**: database
        /// *   **lkm**: kernel module
        /// *   **autorun**: startup item
        /// *   **web_server**: web service
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUIDs of the assets. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
