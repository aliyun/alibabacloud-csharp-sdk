// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The keyword of the endpoint name, which is used for fuzzy searches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The state of the endpoint that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: The endpoint works as expected.</description></item>
        /// <item><description>INIT: The endpoint is being created.</description></item>
        /// <item><description>FAILED: The endpoint failed to be created.</description></item>
        /// <item><description>CHANGE_INIT: The endpoint is being modified.</description></item>
        /// <item><description>CHANGE_FAILED: The endpoint failed to be modified.</description></item>
        /// <item><description>EXCEPTION: The endpoint encountered an exception.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, endpoints in all states are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The region ID of the outbound virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
