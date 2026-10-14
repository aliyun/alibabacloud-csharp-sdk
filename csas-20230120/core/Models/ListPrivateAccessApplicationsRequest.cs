// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The access mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>app</b>: application access. Filters applications that support application access.</description></item>
        /// <item><description><b>browser</b>: browser access. Filters applications that support browser access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AccessModes")]
        [Validation(Required=false)]
        public string AccessModes { get; set; }

        /// <summary>
        /// <para>The address of the private access application. The address must be 1 to 128 characters in length, and can be an IPv4 address, a CIDR block, a domain name, or a wildcard domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IDs of the private access applications. You can specify up to 100 IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The ID of the connector. You can obtain the ID from the following operation: <a href="~~ListConnectors~~">ListConnectors</a>: List connectors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-94db94e06b98****</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Filters applications by health check status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: The success rate of the last check is greater than or equal to 95%.</description></item>
        /// <item><description>partialError: The success rate of the last check is greater than 0 and less than 95%.</description></item>
        /// <item><description>error: The success rate of the last check is 0.</description></item>
        /// <item><description>uncompleted: No check results are available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public string HealthCheckStatus { get; set; }

        /// <summary>
        /// <para>The name of the private access application. The name must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_application_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page in a paging query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the private access policy. You can obtain the ID from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: List private access policies.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create a private access policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-54a7838a48bf****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The status of the private access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the private access tag. You can obtain the ID from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: List private access tags.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: Create a private access tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
