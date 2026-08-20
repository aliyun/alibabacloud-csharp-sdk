// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The keyword for the endpoint name. A fuzzy search is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint-test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number for a paged query. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SUCCESS: The endpoint is working as expected.</para>
        /// </description></item>
        /// <item><description><para>INIT: The endpoint is being created.</para>
        /// </description></item>
        /// <item><description><para>FAILED: The endpoint failed to be created.</para>
        /// </description></item>
        /// <item><description><para>CHANGE_INIT: The endpoint is being modified.</para>
        /// </description></item>
        /// <item><description><para>CHANGE_FAILED: The endpoint failed to be modified.</para>
        /// </description></item>
        /// <item><description><para>EXCEPTION: The endpoint is not working as expected.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, endpoints in all states are returned. If you specify this parameter, only endpoints in the specified state are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the region where the outbound virtual private cloud (VPC) is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
