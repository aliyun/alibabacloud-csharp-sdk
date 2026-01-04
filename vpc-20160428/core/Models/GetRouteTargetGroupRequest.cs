// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetRouteTargetGroupRequest : TeaModel {
        /// <summary>
        /// <para>Client token, used to ensure idempotence of the request.</para>
        /// <para>Generate a parameter value from your client and ensure that it is unique across different requests. ClientToken only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b> identifier. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>ID of the region to which the route target group belongs. You can obtain the region ID by calling the DescribeRegions interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>ID of the route target group member instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtg-xxxx</para>
        /// </summary>
        [NameInMap("RouteTargetGroupId")]
        [Validation(Required=false)]
        public string RouteTargetGroupId { get; set; }

        /// <summary>
        /// <para>Tag information.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetRouteTargetGroupRequestTag> Tag { get; set; }
        public class GetRouteTargetGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>Resource tag key. Up to 20 tag keys are supported. If you need to pass this value, you cannot input an empty string.</para>
            /// <para>A tag key can have up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Resource tag value. Up to 20 tag values are supported. If you need to pass this value, you can input an empty string.</para>
            /// <para>A tag value can have up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
