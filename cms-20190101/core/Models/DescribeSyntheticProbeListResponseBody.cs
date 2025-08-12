// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSyntheticProbeListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The queried detection points.</para>
        /// </summary>
        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public List<DescribeSyntheticProbeListResponseBodyIspCityList> IspCityList { get; set; }
        public class DescribeSyntheticProbeListResponseBodyIspCityList : TeaModel {
            [NameInMap("AreaCn")]
            [Validation(Required=false)]
            public string AreaCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Huabei</para>
            /// </summary>
            [NameInMap("AreaEn")]
            [Validation(Required=false)]
            public string AreaEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>738</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CityCn")]
            [Validation(Required=false)]
            public string CityCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("CityEn")]
            [Validation(Required=false)]
            public string CityEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>629</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("CountryCn")]
            [Validation(Required=false)]
            public string CountryCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("CountryEn")]
            [Validation(Required=false)]
            public string CountryEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdcV4ProbeCount")]
            [Validation(Required=false)]
            public int? IdcV4ProbeCount { get; set; }

            /// <summary>
            /// <para>The number of IPv6 nodes in data centers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdcV6ProbeCount")]
            [Validation(Required=false)]
            public int? IdcV6ProbeCount { get; set; }

            /// <summary>
            /// <para>The IP addresses of the monitored nodes.</para>
            /// </summary>
            [NameInMap("IpPool")]
            [Validation(Required=false)]
            public List<string> IpPool { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("IspCn")]
            [Validation(Required=false)]
            public string IspCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>China-Unicom</para>
            /// </summary>
            [NameInMap("IspEn")]
            [Validation(Required=false)]
            public string IspEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LmProbeCount")]
            [Validation(Required=false)]
            public int? LmProbeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MbProbeCount")]
            [Validation(Required=false)]
            public int? MbProbeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("RegionCn")]
            [Validation(Required=false)]
            public string RegionCn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Jiangxi</para>
            /// </summary>
            [NameInMap("RegionEn")]
            [Validation(Required=false)]
            public string RegionEn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87170bc7-e28a-4c93-b9bf-90a1dbe84736</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
