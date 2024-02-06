// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandWithdChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// The information about the metering method.
        /// </summary>
        [NameInMap("BandWithTypeInfo")]
        [Validation(Required=false)]
        public string BandWithTypeInfo { get; set; }

        /// <summary>
        /// The metering type.
        /// 
        /// *   ChargeByUnified: unified metering.
        /// *   ChargeByGrade: differential metering.
        /// </summary>
        [NameInMap("ChargeContractType")]
        [Validation(Required=false)]
        public string ChargeContractType { get; set; }

        /// <summary>
        /// The metering cycle. Currently, this parameter is empty in the response.
        /// </summary>
        [NameInMap("ChargeCycleInfo")]
        [Validation(Required=false)]
        public string ChargeCycleInfo { get; set; }

        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
