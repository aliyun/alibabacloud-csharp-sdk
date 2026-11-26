// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDeviceBelongIdentifiersRequest : TeaModel {
        /// <summary>
        /// <para>The current page number. Valid values: 1 to 2147483647.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of record IDs to query. You can specify 1 to 100 positive integer decimal strings at a time. If this parameter is specified along with other filter parameters, the records that meet all the conditions are returned.</para>
        /// </summary>
        [NameInMap("IdentifierIds")]
        [Validation(Required=false)]
        public List<string> IdentifierIds { get; set; }

        /// <summary>
        /// <para>The identifier type. MAC indicates the MAC address of the network interface controller (NIC), SystemSN indicates the system serial number, and BIOSSN indicates the BIOS serial number. This parameter is required when IdentifierValues is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MAC</para>
        /// </summary>
        [NameInMap("IdentifierType")]
        [Validation(Required=false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// <para>The list of identifier values for exact match. You can specify 1 to 100 items at a time, and each item can contain 1 to 128 characters. You must specify IdentifierType at the same time. Records that match any value in the array are returned. MAC addresses are uniformly converted to the lowercase colon-separated format. System serial numbers and BIOS serial numbers are case-sensitive and space-sensitive.</para>
        /// </summary>
        [NameInMap("IdentifierValues")]
        [Validation(Required=false)]
        public List<string> IdentifierValues { get; set; }

        /// <summary>
        /// <para>A reserved pagination parameter. This value is not used in the current version. Use PageSize to specify the number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A reserved pagination cursor. This value is not used in the current version. Use CurrentPage to specify the page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d9fbd0d1ac24be90</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return per page. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
