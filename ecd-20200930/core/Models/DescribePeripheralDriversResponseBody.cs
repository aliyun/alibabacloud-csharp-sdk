// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePeripheralDriversResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of matching drivers, not the length of the current page list. This value may be 0 when the current page contains no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of driver information on the current page. An empty list is returned when no data is available.</para>
        /// </summary>
        [NameInMap("DriverInfos")]
        [Validation(Required=false)]
        public List<DescribePeripheralDriversResponseBodyDriverInfos> DriverInfos { get; set; }
        public class DescribePeripheralDriversResponseBodyDriverInfos : TeaModel {
            /// <summary>
            /// <para>The brand to which the driver belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hp</para>
            /// </summary>
            [NameInMap("Brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            /// <summary>
            /// <para>The time when the driver record was created, in ISO 8601 (RFC 3339) format with a time zone offset. The time zone offset is based on the returned value. This field may be empty or not returned if the time information does not exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The device type to which the driver applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>printer</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The brand icon URL. This field may be empty or not returned if no icon is configured. The example value is for illustration purposes only.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/icons/printer.png">https://example.com/icons/printer.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The driver ID, which can be used for subsequent queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The driver name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HP Universal Printing PCL 6</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operating system to which the driver applies, such as Windows. The actual returned value prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The driver ownership. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WUYING: Wuying official driver.</description></item>
            /// <item><description>CUSTOMER: Custom driver of the current account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The driver source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OpsApp: Uploaded from the management console.</description></item>
            /// <item><description>WuyingHelper: Uploaded from Wuying Helper.</description></item>
            /// <item><description>Wuying: Wuying source.</description></item>
            /// </list>
            /// <para>Unrecognized sources may also be classified as Wuying. To distinguish between official and custom drivers, use OwnerType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wuying</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>Reserved field. This field does not provide a valid return value and may not be returned. This operation uses PageSize and PageNumber for pagination. Do not rely on this field. The example value 20 is provided only to illustrate the integer type and does not represent the actual return value, default value, or page size of this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Reserved field. Token-based pagination is not supported and this field may not be returned. Do not rely on this field for continued queries. The example value token-for-format-only is provided only to illustrate the string type and is not an actual return value or a usable pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-for-format-only</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. Provide this value when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-1111-4222-8333-444444444444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
