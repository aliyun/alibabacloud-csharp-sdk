// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeResourceByCenterPolicyIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48174475-5EB2-5F99-A9E9-6F892D645****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceModelList")]
        [Validation(Required=false)]
        public List<DescribeResourceByCenterPolicyIdResponseBodyResourceModelList> ResourceModelList { get; set; }
        public class DescribeResourceByCenterPolicyIdResponseBodyResourceModelList : TeaModel {
            [NameInMap("AppModelList")]
            [Validation(Required=false)]
            public List<DescribeResourceByCenterPolicyIdResponseBodyResourceModelListAppModelList> AppModelList { get; set; }
            public class DescribeResourceByCenterPolicyIdResponseBodyResourceModelListAppModelList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alipic-powergem</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.8c32g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.125</para>
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public double? GpuCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2GiB</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>postPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desktop</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-d7pasxsd3b9nhq**</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ResourceGroupRelCount")]
            [Validation(Required=false)]
            public int? ResourceGroupRelCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-7o96aa08fr****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Stopped</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
