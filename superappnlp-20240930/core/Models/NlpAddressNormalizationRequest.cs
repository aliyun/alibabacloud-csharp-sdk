// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SuperappNlp20240930.Models
{
    public class NlpAddressNormalizationRequest : TeaModel {
        [NameInMap("CityStdManual")]
        [Validation(Required=false)]
        public string CityStdManual { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BACOLOR</para>
        /// </summary>
        [NameInMap("CityStr")]
        [Validation(Required=false)]
        public string CityStr { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DistrictStdManual")]
        [Validation(Required=false)]
        public string DistrictStdManual { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10671</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ProvinceStdManual")]
        [Validation(Required=false)]
        public string ProvinceStdManual { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAMPANGA</para>
        /// </summary>
        [NameInMap("ProvinceStr")]
        [Validation(Required=false)]
        public string ProvinceStr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>350 Magliman, Bacolor, Pampanga AQUA MALTA Refilling Station</para>
        /// </summary>
        [NameInMap("QueryStr")]
        [Validation(Required=false)]
        public string QueryStr { get; set; }

    }

}
