// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20200710.Models
{
    public class GetDeployDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDeployDetailResponseBodyData> Data { get; set; }
        public class GetDeployDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>EQ4W772D0VJ33IV1</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1645516991000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEPLOY</para>
            /// </summary>
            [NameInMap("CurrentProcess")]
            [Validation(Required=false)]
            public string CurrentProcess { get; set; }

            [NameInMap("DeletingNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeletingNodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeployPercent")]
            [Validation(Required=false)]
            public double? DeployPercent { get; set; }

            [NameInMap("DeployedNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeployedNodeList { get; set; }

            [NameInMap("DeployingNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeployingNodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OperationNotSupport.SubscriptionCommodityCanNotDelete</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public int? ExecutionTime { get; set; }

            [NameInMap("FailStatus")]
            [Validation(Required=false)]
            public int? FailStatus { get; set; }

            [NameInMap("OrderIdList")]
            [Validation(Required=false)]
            public List<string> OrderIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://cadt-studio-publish.oss-cn-hangzhou.aliyuncs.com/1986207497633020/deployReport-EXN4FNUR12M35KJM.pdf?Expires=1716967763&OSSAccessKeyId=********nw4rvYAweFuQc3&Signature=*******fKo6164wykT9jBOsSGeQ%3D">https://cadt-studio-publish.oss-cn-hangzhou.aliyuncs.com/1986207497633020/deployReport-EXN4FNUR12M35KJM.pdf?Expires=1716967763&amp;OSSAccessKeyId=********nw4rvYAweFuQc3&amp;Signature=*******fKo6164wykT9jBOsSGeQ%3D</a></para>
            /// </summary>
            [NameInMap("PdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aekzhfgmw4e6fwq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetDeployDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetDeployDetailResponseBodyDataResourceList : TeaModel {
                [NameInMap("BuyDuration")]
                [Validation(Required=false)]
                public string BuyDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Free</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OpenApi</para>
                /// </summary>
                [NameInMap("ExecutionStrategy")]
                [Validation(Required=false)]
                public string ExecutionStrategy { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1714031840000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://cloudmonitor.console.aliyun.com/?#/generalcharts/product=vpc&group=&type=&return&region=cn-hangzhou&dimension=instanceId:vpc-bp1n6uc5jqxtff2euhnx5">https://cloudmonitor.console.aliyun.com/?#/generalcharts/product=vpc&amp;group=&amp;type=&amp;return&amp;region=cn-hangzhou&amp;dimension=instanceId:vpc-bp1n6uc5jqxtff2euhnx5</a></para>
                /// </summary>
                [NameInMap("MonitorURL")]
                [Validation(Required=false)]
                public string MonitorURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public GetDeployDetailResponseBodyDataResourceListOperation Operation { get; set; }
                public class GetDeployDetailResponseBodyDataResourceListOperation : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ecsDelete</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Operations")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Operations { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1716049421</para>
                /// </summary>
                [NameInMap("RefId")]
                [Validation(Required=false)]
                public long? RefId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Description\&quot;:\&quot;\&quot;,\&quot;ClassicLinkEnabled\&quot;:false,\&quot;ResourceGroupId\&quot;:\&quot;rg-acfm4mlwqjalz7a\&quot;,\&quot;SecondaryCidrBlocks\&quot;:[],\&quot;CidrBlock\&quot;:\&quot;192.168.0.0/16\&quot;,\&quot;UserCidrs\&quot;:[],\&quot;NetworkAclNum\&quot;:\&quot;0\&quot;,\&quot;VRouterId\&quot;:\&quot;vrt-m5ek7vcyld0x5ym8m9hix\&quot;,\&quot;OwnerId\&quot;:1986207497633020,\&quot;AssociatedCens\&quot;:[],\&quot;id\&quot;:\&quot;vpc-m5e3c9nz4lj19byan9m2g\&quot;,\&quot;CloudResources\&quot;:[{\&quot;ResourceCount\&quot;:1,\&quot;ResourceType\&quot;:\&quot;VSwitch\&quot;},{\&quot;ResourceCount\&quot;:1,\&quot;ResourceType\&quot;:\&quot;VRouter\&quot;},{\&quot;ResourceCount\&quot;:1,\&quot;ResourceType\&quot;:\&quot;RouteTable\&quot;}],\&quot;Tags\&quot;:[],\&quot;Status\&quot;:\&quot;Available\&quot;,\&quot;IsDefault\&quot;:false,\&quot;RequestId\&quot;:\&quot;494646FB-14C0-5B4C-9684-B6EFBF4DF01C\&quot;,\&quot;SupportIpv4Gateway\&quot;:false,\&quot;Ipv4GatewayId\&quot;:\&quot;\&quot;,\&quot;VSwitchIds\&quot;:[\&quot;vsw-m5egl9wtppiadysjwlgb1\&quot;],\&quot;VpcId\&quot;:\&quot;vpc-m5e3c9nz4lj19byan9m2g\&quot;,\&quot;CreationTime\&quot;:\&quot;2024-04-25T07:56:59Z\&quot;,\&quot;VpcName\&quot;:\&quot;vpc\&quot;,\&quot;refId\&quot;:\&quot;1714031764_0\&quot;,\&quot;RegionId\&quot;:\&quot;cn-qingdao\&quot;,\&quot;Ipv6CidrBlock\&quot;:\&quot;\&quot;,\&quot;Ipv6CidrBlocks\&quot;:[]}</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-2zehnzxqixu1pywsfbx1</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceTimeList")]
                [Validation(Required=false)]
                public List<GetDeployDetailResponseBodyDataResourceListResourceTimeList> ResourceTimeList { get; set; }
                public class GetDeployDetailResponseBodyDataResourceListResourceTimeList : TeaModel {
                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    [NameInMap("CreationEndTime")]
                    [Validation(Required=false)]
                    public long? CreationEndTime { get; set; }

                    [NameInMap("CreationStartTime")]
                    [Validation(Required=false)]
                    public long? CreationStartTime { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Finish</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Revised</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://cadt-studio-publish.oss-cn-hangzhou.aliyuncs.com/1986207497633020/app_EXN4FNUR12M35KJM.tf?Expires=1716967763&OSSAccessKeyId=*******nw4rvYAweFuQc3&Signature=%2********lYROqJLNvyA8g6qD9U%3D">https://cadt-studio-publish.oss-cn-hangzhou.aliyuncs.com/1986207497633020/app_EXN4FNUR12M35KJM.tf?Expires=1716967763&amp;OSSAccessKeyId=*******nw4rvYAweFuQc3&amp;Signature=%2********lYROqJLNvyA8g6qD9U%3D</a></para>
            /// </summary>
            [NameInMap("TerraformScriptUrl")]
            [Validation(Required=false)]
            public string TerraformScriptUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E15B71B4-5D8F-5484-BC07-989E2987EE7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
