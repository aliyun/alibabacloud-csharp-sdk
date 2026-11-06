// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataSetRequest : TeaModel {
        [NameInMap("DataSetDescription")]
        [Validation(Required=false)]
        public string DataSetDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSetFieldKeyName")]
        [Validation(Required=false)]
        public string DataSetFieldKeyName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSetName")]
        [Validation(Required=false)]
        public string DataSetName { get; set; }

        [NameInMap("DataSetStatus")]
        [Validation(Required=false)]
        public int? DataSetStatus { get; set; }

        [NameInMap("DataSetType")]
        [Validation(Required=false)]
        public string DataSetType { get; set; }

        [NameInMap("IpWhitelistRecognizers")]
        [Validation(Required=false)]
        public List<CreateDataSetRequestIpWhitelistRecognizers> IpWhitelistRecognizers { get; set; }
        public class CreateDataSetRequestIpWhitelistRecognizers : TeaModel {
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
