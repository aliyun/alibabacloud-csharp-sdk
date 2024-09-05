/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ConfigNetStatusRequest : TeaModel {
        /// <summary>
        /// The CIDR block of the anti-DDoS diversion instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        /// <summary>
        /// The regions in which the CIDR block needs to be advertised or withdrawn from advertising. If you leave this parameter empty, the CIDR blocks in all regions are configured.
        /// 
        /// >  You can call the [QueryNetList](https://help.aliyun.com/document_detail/2639086.html) operation to obtain the regions of the CIDR blocks.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// The ID of the anti-DDoS diversion instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        /// <summary>
        /// The status of the CIDR block. Valid values:
        /// 
        /// *   enable: advertises the CIDR block.
        /// *   disable: withdraws the advertising of the CIDR block.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The subnet CIDR blocks of the CIDR block.
        /// </summary>
        [NameInMap("SubNets")]
        [Validation(Required=false)]
        public List<string> SubNets { get; set; }

    }

}
