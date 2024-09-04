// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ExportCustomerQuotaRecordRequest : TeaModel {
        /// <summary>
        /// End Date Format:  yyyy-MM-dd
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Customer UID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndUserPk")]
        [Validation(Required=false)]
        public long? EndUserPk { get; set; }

        /// <summary>
        /// Multilingual Parameters, the default language is English.</br>
        /// en: English</br>
        /// zh: Chinese</br>
        /// ja: Japanese </br>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// Operation Type Enum</br>
        /// all All types</br>
        /// quota_create Create quota</br>
        /// quota_amount_adjust Adjust the amount of quota</br>
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// Start Date Format:  yyyy-MM-dd
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
