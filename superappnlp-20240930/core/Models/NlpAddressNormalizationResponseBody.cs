// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SuperappNlp20240930.Models
{
    public class NlpAddressNormalizationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public NlpAddressNormalizationResponseBodyData Data { get; set; }
        public class NlpAddressNormalizationResponseBodyData : TeaModel {
            [NameInMap("CityStd")]
            [Validation(Required=false)]
            public string CityStd { get; set; }

            [NameInMap("DistrictStd")]
            [Validation(Required=false)]
            public string DistrictStd { get; set; }

            [NameInMap("ProvinceStd")]
            [Validation(Required=false)]
            public string ProvinceStd { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<string> Results { get; set; }

            [NameInMap("StatusEs")]
            [Validation(Required=false)]
            public string StatusEs { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>99540D1A-9112-56E5-8DCC-1A2603F4C500</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1701051540592</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
