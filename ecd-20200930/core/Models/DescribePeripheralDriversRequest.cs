// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePeripheralDriversRequest : TeaModel {
        /// <summary>
        /// <para>The brand identifier. Exact match. The value is based on the actual configuration and has no fixed enumeration. If this parameter is not specified, the brand is not limited. The example is used only to illustrate the format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hp</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        /// <summary>
        /// <para>The device type identifier. Exact match. The value is based on the actual configuration. For example, printer indicates a printer. If this parameter is not specified, the device type is not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>printer</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The list of driver IDs. If this parameter is not specified or an empty array is passed, the driver ID is not limited. Only the drivers that are visible to the current account and match the conditions are returned. Unmatched IDs do not generate corresponding records.</para>
        /// </summary>
        [NameInMap("DriverIds")]
        [Validation(Required=false)]
        public List<string> DriverIds { get; set; }

        /// <summary>
        /// <para>The search keyword. Matches the driver ID, brand identifier, driver name, description, device type, or brand display name. A match in any field is considered a hit. The percent sign (%) matches characters of any length, and the underscore (_) matches a single character. If this parameter is not specified, keyword filtering is not performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LaserJet</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not used for querying or pagination. Do not specify this parameter. Use PageSize to set the number of entries to return on each page. The sample value 20 is used only to demonstrate the integer type. It is not the default value of this parameter and does not take effect even if specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The reserved parameter. Token-based pagination is not supported. Do not specify this parameter. Use PageNumber to specify the page number. The sample value token-for-format-only is used only to demonstrate the string type and is not a usable pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-for-format-only</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The driver ownership. Valid values: WUYING: Wuying official drivers. CUSTOMER: custom drivers of the current account. If this parameter is not specified, both types of drivers are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOMER</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The page number. Specify a value starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 500. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
