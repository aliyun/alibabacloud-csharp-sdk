// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>lmftest desc</para>
        /// </summary>
        [NameInMap("DataSetDescription")]
        [Validation(Required=false)]
        public string DataSetDescription { get; set; }

        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-10iy8mbifnb4gniv****</para>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoRecognizeStatus")]
            [Validation(Required=false)]
            public string AutoRecognizeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cdn_back_source_ip</para>
            /// </summary>
            [NameInMap("IpWhitelistRecognizerType")]
            [Validation(Required=false)]
            public string IpWhitelistRecognizerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>current_account</para>
            /// </summary>
            [NameInMap("RecognizeScope")]
            [Validation(Required=false)]
            public string RecognizeScope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
