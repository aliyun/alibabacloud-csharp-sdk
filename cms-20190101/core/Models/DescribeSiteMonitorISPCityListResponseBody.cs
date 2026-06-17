// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListResponseBody : TeaModel {
        /// <summary>
        /// <para>状态码。</para>
        /// <remarks>
        /// <para>200表示成功。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public DescribeSiteMonitorISPCityListResponseBodyIspCityList IspCityList { get; set; }
        public class DescribeSiteMonitorISPCityListResponseBodyIspCityList : TeaModel {
            [NameInMap("IspCity")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity> IspCity { get; set; }
            public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCity : TeaModel {
                [NameInMap("Area.en")]
                [Validation(Required=false)]
                public string Area_en { get; set; }

                [NameInMap("Area.zh_CN")]
                [Validation(Required=false)]
                public string Area_zh_cN { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("CityName.en")]
                [Validation(Required=false)]
                public string CityName_en { get; set; }

                [NameInMap("CityName.zh_CN")]
                [Validation(Required=false)]
                public string CityName_zh_cN { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("Country.en")]
                [Validation(Required=false)]
                public string Country_en { get; set; }

                [NameInMap("Country.zh_CN")]
                [Validation(Required=false)]
                public string Country_zh_cN { get; set; }

                [NameInMap("IPPool")]
                [Validation(Required=false)]
                public DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool IPPool { get; set; }
                public class DescribeSiteMonitorISPCityListResponseBodyIspCityListIspCityIPPool : TeaModel {
                    [NameInMap("IPPool")]
                    [Validation(Required=false)]
                    public List<string> IPPool { get; set; }

                }

                [NameInMap("IPV4ProbeCount")]
                [Validation(Required=false)]
                public string IPV4ProbeCount { get; set; }

                [NameInMap("IPV6ProbeCount")]
                [Validation(Required=false)]
                public string IPV6ProbeCount { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("IspName.en")]
                [Validation(Required=false)]
                public string IspName_en { get; set; }

                [NameInMap("IspName.zh_CN")]
                [Validation(Required=false)]
                public string IspName_zh_cN { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Region.en")]
                [Validation(Required=false)]
                public string Region_en { get; set; }

                [NameInMap("Region.zh_CN")]
                [Validation(Required=false)]
                public string Region_zh_cN { get; set; }

            }

        }

        /// <summary>
        /// <para>返回信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>B35D7D84-547B-4E61-B909-48A1F8A0C756</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>操作是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>true：成功。</para>
        /// </description></item>
        /// <item><description><para>false：失败。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
