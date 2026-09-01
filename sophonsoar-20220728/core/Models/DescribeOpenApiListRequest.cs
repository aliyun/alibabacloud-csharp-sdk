// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeOpenApiListRequest : TeaModel {
        /// <summary>
        /// <para>The API name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DescribePopApiItemList</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The API version number.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeGroupProductions~~">DescribeGroupProductions</a> API to get this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. The default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The POP CODE of the Alibaba Cloud product API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// <para>The user ID of the member whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137602xxx8718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. The default is 0. Values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Current Alibaba Cloud account view.</para>
        /// </description></item>
        /// <item><description><para>1: View of all accounts under the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
