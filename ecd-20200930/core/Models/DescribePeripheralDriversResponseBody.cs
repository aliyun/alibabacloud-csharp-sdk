// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePeripheralDriversResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of matched drivers, not the length of the list on the current page. If no data exists on the current page, 0 may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of driver information on the current page. An empty list is returned if no data exists.</para>
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
            /// <para>The time when the driver record was created. The time is in the ISO 8601 (RFC 3339) format with time zone offset. The time zone offset is subject to the returned value. If the time information does not exist, this field may be empty or not returned.</para>
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
            /// <para>The URL of the brand icon. If no icon is configured, this field may be empty or not returned. The example is a placeholder address.</para>
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
            /// <para>The driver ownership. Valid values: WUYING: Wuying official drivers. CUSTOMER: custom drivers of the current account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The driver source. Valid values: OpsApp: uploaded from the management console. WuyingHelper: uploaded from Wuying Assistant. Wuying: from Wuying. Unrecognized sources may also be classified as Wuying. To distinguish between official and custom drivers, use OwnerType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wuying</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The reserved field. This field does not provide a valid return value and may not be returned. This operation uses PageSize and PageNumber for pagination. Do not rely on this field. The sample value 20 is used only to demonstrate the integer type and does not represent the actual return value, default value, or page size of the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The reserved field. This field does not provide token-based pagination and may not be returned. Do not rely on this field for subsequent queries. The sample value token-for-format-only is used only to demonstrate the string type and is not an actual return value or a usable pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-for-format-only</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-1111-4222-8333-444444444444</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
