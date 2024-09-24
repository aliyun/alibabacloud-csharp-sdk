// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudVendorRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The regions that the service provider supports.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCloudVendorRegionsResponseBodyData> Data { get; set; }
        public class ListCloudVendorRegionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The area to which the region belongs. The valid values vary based on the value of the Vendor parameter.</para>
            /// <list type="bullet">
            /// <item><description>Valid values if <b>Vendor</b> is set to Tencent:</description></item>
            /// <item><description><b>cn</b>: China</description></item>
            /// <item><description><b>southeast_asia</b>: Southeast Asia Pacific</description></item>
            /// <item><description><b>northeast_asia</b>: Northeast Asia Pacific</description></item>
            /// <item><description><b>southern_asia</b>: South Asia Pacific</description></item>
            /// <item><description><b>north_America</b>: North America</description></item>
            /// <item><description><b>south_America</b>: South America</description></item>
            /// <item><description><b>western_America</b>: Western United States</description></item>
            /// <item><description><b>eastern_America</b>: Eastern United States</description></item>
            /// <item><description><b>european</b>: Europe</description></item>
            /// <item><description>Valid values if <b>Vendor</b> is set to HUAWEICLOUD:</description></item>
            /// <item><description><b>cn</b>: China</description></item>
            /// <item><description><b>africa</b>: Africa</description></item>
            /// <item><description><b>latin_america</b>: Latin America</description></item>
            /// <item><description><b>asia</b>: Asia Pacific</description></item>
            /// <item><description>Valid values if <b>Vendor</b> is set to Azure:</description></item>
            /// <item><description><b>middle_east</b>: Middle East</description></item>
            /// <item><description><b>south_america</b>: South America</description></item>
            /// <item><description><b>canada</b>: Canada</description></item>
            /// <item><description><b>asia-pacific</b>: Asia Pacific</description></item>
            /// <item><description><b>europe</b>: Europe</description></item>
            /// <item><description><b>africa</b>: Africa</description></item>
            /// <item><description><b>us</b>: United States</description></item>
            /// <item><description><b>other</b>: other regions</description></item>
            /// <item><description>Valid values if <b>Vendor</b> is set to AWS:</description></item>
            /// <item><description><b>cn</b>: China</description></item>
            /// <item><description><b>us</b>: United States</description></item>
            /// <item><description><b>eu</b>: Europe</description></item>
            /// <item><description><b>asia</b>: Asia Pacific</description></item>
            /// <item><description><b>south_america</b>: South America</description></item>
            /// <item><description><b>me</b>: Middle East</description></item>
            /// <item><description><b>ca</b>: Canada</description></item>
            /// <item><description><b>af</b>: Africa</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>Indicates whether the region is configured as a synchronization region on another site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The region is not configured as a synchronization region on another site.</description></item>
            /// <item><description><b>1</b>: The region is configured as a synchronization region on another site.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public int? Disable { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the region is configured as a synchronization region on this site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The region is not configured as a synchronization region on this site.</description></item>
            /// <item><description><b>1</b>: The region is configured as a synchronization region on this site.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Selected")]
            [Validation(Required=false)]
            public int? Selected { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C87EC6AD-4590-5546-9DF6-B8956579D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
