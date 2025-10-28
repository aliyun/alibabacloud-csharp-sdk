// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of SLB instances.</para>
        /// </summary>
        [NameInMap("SlbList")]
        [Validation(Required=false)]
        public ListSlbResponseBodySlbList SlbList { get; set; }
        public class ListSlbResponseBodySlbList : TeaModel {
            [NameInMap("SlbEntity")]
            [Validation(Required=false)]
            public List<ListSlbResponseBodySlbListSlbEntity> SlbEntity { get; set; }
            public class ListSlbResponseBodySlbListSlbEntity : TeaModel {
                /// <summary>
                /// <para>The IP address of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.176.XX.XX</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The type of the IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>internet: Users can connect to the SLB instance over the Internet.</description></item>
                /// <item><description>intranet: Users can connect to the SLB instance over the internal network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>internet</para>
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>Indicates whether the SLB instance has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The SLB instance has expired.</description></item>
                /// <item><description>false: The SLB instance has not expired.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// <para>The ID of the resource group in Enterprise Distributed Application Service (EDAS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// <para>The type of the network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>classic</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Indicates whether Kubernetes applications can be reused. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Kubernetes applications can be reused.</description></item>
                /// <item><description>false: Kubernetes applications cannot be reused.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Reusable")]
                [Validation(Required=false)]
                public bool? Reusable { get; set; }

                /// <summary>
                /// <para>The ID of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-2ze055t3xv7s8****</para>
                /// </summary>
                [NameInMap("SlbId")]
                [Validation(Required=false)]
                public string SlbId { get; set; }

                /// <summary>
                /// <para>The name of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adce</para>
                /// </summary>
                [NameInMap("SlbName")]
                [Validation(Required=false)]
                public string SlbName { get; set; }

                /// <summary>
                /// <para>The status of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("SlbStatus")]
                [Validation(Required=false)]
                public string SlbStatus { get; set; }

                /// <summary>
                /// <para>The tag of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;tagKey&quot;:&quot;tag&quot;,&quot;tagValue&quot;:&quot;value&quot;}]</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas_****_*<em>st@aliyun-</em>***.com</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1f90rfybszjogyw****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp156w1gpbv0o50hs****</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

    }

}
