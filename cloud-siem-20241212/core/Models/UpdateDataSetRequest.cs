// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSetRequest : TeaModel {
        [NameInMap("DataSetDescription")]
        [Validation(Required=false)]
        public string DataSetDescription { get; set; }

        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSetId")]
        [Validation(Required=false)]
        public string DataSetId { get; set; }

        [NameInMap("DataSetName")]
        [Validation(Required=false)]
        public string DataSetName { get; set; }

        [NameInMap("DataSetStatus")]
        [Validation(Required=false)]
        public int? DataSetStatus { get; set; }

        [NameInMap("IpWhitelistRecognizers")]
        [Validation(Required=false)]
        public List<UpdateDataSetRequestIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
        public class UpdateDataSetRequestIpWhitelistRecognizers : TeaModel {
            [NameInMap("AutoRecognizeStatus")]
            [Validation(Required=false)]
            public string AutoRecognizeStatus { get; set; }

            [NameInMap("IpWhitelistRecognizerType")]
            [Validation(Required=false)]
            public string IpWhitelistRecognizerType { get; set; }

            [NameInMap("RecognizeScope")]
            [Validation(Required=false)]
            public string RecognizeScope { get; set; }

        }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
