// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeEdgeMobileAgentPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The device type filter. Valid values: BOX, PHONE, PAD, and OTHER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOX</para>
        /// </summary>
        [NameInMap("DeviceClass")]
        [Validation(Required=false)]
        public string DeviceClass { get; set; }

        /// <summary>
        /// <para>The list of license keys. Separate multiple keys with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lic-ez197xvdf0j5eo0*****</para>
        /// </summary>
        [NameInMap("LicenseKeys")]
        [Validation(Required=false)]
        public string LicenseKeys { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first query. For subsequent queries, use the value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of package IDs. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmag-0c1g77wjljl9hc****</para>
        /// </summary>
        [NameInMap("PackageIds")]
        [Validation(Required=false)]
        public string PackageIds { get; set; }

        /// <summary>
        /// <para>The package status filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
