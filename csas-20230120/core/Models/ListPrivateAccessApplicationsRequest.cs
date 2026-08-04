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
        /// <para>The address of the internal-facing access application. The address is 1 to 128 characters in length and supports IPv4 addresses, CIDR blocks, domain names, and wildcard domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IDs of internal-facing access applications. You can specify up to 100 application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The connector ID. You can obtain the ID from the <a href="~~ListConnectors~~">ListConnectors</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-94db94e06b98****</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The page number of the current page displayed in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the internal-facing access application. The name is 1 to 128 characters in length, supports Chinese and uppercase and lowercase letters, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_application_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the internal-facing access policy. You can obtain the ID from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: queries internal-facing access policies in batches.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: creates an internal-facing access policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-54a7838a48bf****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The status of the internal-facing access application. Valid values:</para>
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
        /// <para>The ID of the internal-facing access tag. You can obtain the ID from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: queries internal-facing access tags in batches.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: creates an internal-facing access tag.</description></item>
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
