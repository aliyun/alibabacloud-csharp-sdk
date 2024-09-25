// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVRoutersResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details about the vRouters.</para>
        /// </summary>
        [NameInMap("VRouters")]
        [Validation(Required=false)]
        public DescribeVRoutersResponseBodyVRouters VRouters { get; set; }
        public class DescribeVRoutersResponseBodyVRouters : TeaModel {
            [NameInMap("VRouter")]
            [Validation(Required=false)]
            public List<DescribeVRoutersResponseBodyVRoutersVRouter> VRouter { get; set; }
            public class DescribeVRoutersResponseBodyVRoutersVRouter : TeaModel {
                /// <summary>
                /// <para>The time when the vRouter was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-03-22T07:46:20Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the vRouter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region to which the vRouter belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the route table in the vRouter.</para>
                /// </summary>
                [NameInMap("RouteTableIds")]
                [Validation(Required=false)]
                public DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds RouteTableIds { get; set; }
                public class DescribeVRoutersResponseBodyVRoutersVRouterRouteTableIds : TeaModel {
                    [NameInMap("RouteTableId")]
                    [Validation(Required=false)]
                    public List<string> RouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vRouter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-rj98khsezfqpjrxmv****</para>
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// <para>The name of the vRouter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doctest</para>
                /// </summary>
                [NameInMap("VRouterName")]
                [Validation(Required=false)]
                public string VRouterName { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) to which the vRouter belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-rj905wotv6y030t1****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
