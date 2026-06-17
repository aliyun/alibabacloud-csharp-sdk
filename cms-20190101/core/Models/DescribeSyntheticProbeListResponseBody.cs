// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSyntheticProbeListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of detection points.</para>
        /// </summary>
        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public List<DescribeSyntheticProbeListResponseBodyIspCityList> IspCityList { get; set; }
        public class DescribeSyntheticProbeListResponseBodyIspCityList : TeaModel {
            /// <summary>
            /// <para>The name of the area in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>华北</para>
            /// </summary>
            [NameInMap("AreaCn")]
            [Validation(Required=false)]
            public string AreaCn { get; set; }

            /// <summary>
            /// <para>The name of the area in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Huabei</para>
            /// </summary>
            [NameInMap("AreaEn")]
            [Validation(Required=false)]
            public string AreaEn { get; set; }

            /// <summary>
            /// <para>The city ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>738</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The name of the city in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("CityCn")]
            [Validation(Required=false)]
            public string CityCn { get; set; }

            /// <summary>
            /// <para>The name of the city in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("CityEn")]
            [Validation(Required=false)]
            public string CityEn { get; set; }

            /// <summary>
            /// <para>The country code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>629</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The name of the country in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("CountryCn")]
            [Validation(Required=false)]
            public string CountryCn { get; set; }

            /// <summary>
            /// <para>The name of the country or region in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("CountryEn")]
            [Validation(Required=false)]
            public string CountryEn { get; set; }

            /// <summary>
            /// <para>The number of IPv4 detection points in data centers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdcV4ProbeCount")]
            [Validation(Required=false)]
            public int? IdcV4ProbeCount { get; set; }

            /// <summary>
            /// <para>The number of IDC IPv6 nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdcV6ProbeCount")]
            [Validation(Required=false)]
            public int? IdcV6ProbeCount { get; set; }

            /// <summary>
            /// <para>The list of node IP addresses.</para>
            /// </summary>
            [NameInMap("IpPool")]
            [Validation(Required=false)]
            public List<string> IpPool { get; set; }

            /// <summary>
            /// <para>The carrier ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The name of the carrier in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>联通</para>
            /// </summary>
            [NameInMap("IspCn")]
            [Validation(Required=false)]
            public string IspCn { get; set; }

            /// <summary>
            /// <para>The name of the carrier in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China-Unicom</para>
            /// </summary>
            [NameInMap("IspEn")]
            [Validation(Required=false)]
            public string IspEn { get; set; }

            /// <summary>
            /// <para>The number of last-mile detection points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LmProbeCount")]
            [Validation(Required=false)]
            public int? LmProbeCount { get; set; }

            /// <summary>
            /// <para>The number of mobile detection points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MbProbeCount")]
            [Validation(Required=false)]
            public int? MbProbeCount { get; set; }

            /// <summary>
            /// <para>The province code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The name of the province in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>江西省</para>
            /// </summary>
            [NameInMap("RegionCn")]
            [Validation(Required=false)]
            public string RegionCn { get; set; }

            /// <summary>
            /// <para>The name of the province in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jiangxi</para>
            /// </summary>
            [NameInMap("RegionEn")]
            [Validation(Required=false)]
            public string RegionEn { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87170bc7-e28a-4c93-b9bf-90a1dbe84736</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values: true: The operation was successful. false: The operation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
