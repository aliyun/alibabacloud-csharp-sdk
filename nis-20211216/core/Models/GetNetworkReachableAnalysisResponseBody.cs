// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNetworkReachableAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID (UID) of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123147627844****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The time when the network path was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-16T07:11:27Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The network path ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-2a1332214fa346b6****</para>
        /// </summary>
        [NameInMap("NetworkPathId")]
        [Validation(Required=false)]
        public string NetworkPathId { get; set; }

        /// <summary>
        /// <para>The parameters of the network path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;sourceId&quot;: &quot;i-bp100g5pbp6kj4p9****&quot;,
        ///   &quot;sourceType&quot;: &quot;ecs&quot;,
        ///   &quot;targetId&quot;: &quot;i-t4n4ltwgbbomzb0g****&quot;,
        ///   &quot;targetType&quot;: &quot;ecs&quot;
        /// }</para>
        /// </summary>
        [NameInMap("NetworkPathParameter")]
        [Validation(Required=false)]
        public string NetworkPathParameter { get; set; }

        /// <summary>
        /// <para>The ID of the task for analyzing network reachability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nra-8607514e71c1484****</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisId")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisId { get; set; }

        /// <summary>
        /// <para>The result of network reachability analysis, which includes the network topology, error codes of network unreachability, and rules of network unreachability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;errorCode&quot;: &quot;&quot;,
        ///   &quot;networkAclData&quot;: {
        ///     &quot;networkAclItems&quot;: [</para>
        /// <pre><c>]
        /// </c></pre>
        /// <para>  },
        ///   &quot;nraId&quot;: &quot;nra-f2c8701a36424094****&quot;,
        ///   &quot;requestId&quot;: &quot;B931F8A0-620E-5230-B77F-3BD7F612****&quot;,
        ///   &quot;routeData&quot;: {
        ///     &quot;routeItems&quot;: [</para>
        /// <pre><c>]
        /// </c></pre>
        /// <para>  },
        ///   &quot;securityGroupData&quot;: {
        ///     &quot;policy&quot;: &quot;accept&quot;,
        ///     &quot;securityGroupItems&quot;: [
        ///       {
        ///         &quot;description&quot;: &quot;default_sg_access_rule&quot;,
        ///         &quot;matchedRule&quot;: {
        ///           &quot;bizProtocol&quot;: &quot;ALL&quot;,
        ///           &quot;creatingTime&quot;: &quot;2022-11-10T03:24:49Z&quot;,
        ///           &quot;description&quot;: &quot;&quot;,
        ///           &quot;destinationCidr&quot;: &quot;&quot;,
        ///           &quot;destinationGroupId&quot;: &quot;sg-wz980j96p8y99co5****&quot;,
        ///           &quot;direction&quot;: &quot;egress&quot;,
        ///           &quot;policy&quot;: &quot;Accept&quot;,
        ///           &quot;portRange&quot;: &quot;-1/-1&quot;,
        ///           &quot;priority&quot;: &quot;1&quot;,
        ///           &quot;sourceCidr&quot;: &quot;&quot;,
        ///           &quot;sourceGroupId&quot;: &quot;&quot;
        ///         },
        ///         &quot;policy&quot;: &quot;accept&quot;,
        ///         &quot;resourceId&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///         &quot;securityGroupId&quot;: &quot;sg-wz980j96p8y99co5****&quot;
        ///       },
        ///       {
        ///         &quot;description&quot;: &quot;user_acl_drop_rule&quot;,
        ///         &quot;matchedRule&quot;: {
        ///           &quot;bizProtocol&quot;: &quot;&quot;,
        ///           &quot;creatingTime&quot;: &quot;&quot;,
        ///           &quot;description&quot;: &quot;&quot;,
        ///           &quot;destinationCidr&quot;: &quot;&quot;,
        ///           &quot;destinationGroupId&quot;: &quot;&quot;,
        ///           &quot;direction&quot;: &quot;&quot;,
        ///           &quot;policy&quot;: &quot;&quot;,
        ///           &quot;portRange&quot;: &quot;&quot;,
        ///           &quot;priority&quot;: &quot;&quot;,
        ///           &quot;sourceCidr&quot;: &quot;&quot;,
        ///           &quot;sourceGroupId&quot;: &quot;&quot;
        ///         },
        ///         &quot;policy&quot;: &quot;&quot;,
        ///         &quot;resourceId&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///         &quot;securityGroupId&quot;: &quot;sg-wz980j96p8y99co****&quot;
        ///       }
        ///     ],
        ///     &quot;securityGroupReportId&quot;: &quot;sgr-4479d23bb37241aab****&quot;
        ///   },
        ///   &quot;status&quot;: &quot;security_group_checking_target&quot;,
        ///   &quot;topologyData&quot;: {
        ///     &quot;positive&quot;: {
        ///       &quot;linkList&quot;: [
        ///         {
        ///           &quot;id&quot;: &quot;i-wz91dk7bor557hp93zyv--&gt;eni-wz92ce4saz1jzazg****&quot;,
        ///           &quot;source&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///           &quot;target&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;
        ///         },
        ///         {
        ///           &quot;id&quot;: &quot;eni-wz92ce4saz1jzazgi13d--&gt;vsw-wz9slpwdcppwfrnee****&quot;,
        ///           &quot;source&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///           &quot;target&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;
        ///         },
        ///         {
        ///           &quot;id&quot;: &quot;vsw-wz9slpwdcppwfrneebcrp--&gt;eni-wz97vry93t6z4lbd****&quot;,
        ///           &quot;source&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///           &quot;target&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;
        ///         },
        ///         {
        ///           &quot;id&quot;: &quot;eni-wz97vry93t6z4lbdgmfi--&gt;i-wz91dk7bor557hp9****&quot;,
        ///           &quot;source&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///           &quot;target&quot;: &quot;i-wz91dk7bor557hp9****&quot;
        ///         }
        ///       ],
        ///       &quot;nodeList&quot;: [
        ///         {
        ///           &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///           &quot;bizInsId&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///           &quot;id&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///           &quot;level&quot;: 1,
        ///           &quot;matchedRoute&quot;: {
        ///             &quot;nextHopSet&quot;: [</para>
        /// <pre><c>        ]
        ///       },
        ///       &quot;nodeType&quot;: &quot;VM&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;trafficLogs&quot;: [
        ///         
        ///       ]
        ///     },
        ///     {
        ///       &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///       &quot;bizInsId&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;id&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;level&quot;: 3,
        ///       &quot;matchedRoute&quot;: {
        ///         &quot;nextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;nodeType&quot;: &quot;VM&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;trafficLogs&quot;: [
        ///         
        ///       ]
        ///     },
        ///     {
        ///       &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///       &quot;bizInsId&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;cidr&quot;: &quot;192.168.0.0/24&quot;,
        ///       &quot;id&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;level&quot;: 2,
        ///       &quot;matchedRoute&quot;: {
        ///         &quot;nextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;nodeType&quot;: &quot;VSW&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;trafficLogs&quot;: [
        ///         
        ///       ]
        ///     },
        ///     {
        ///       &quot;bizInsId&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;id&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;ip&quot;: &quot;192.168.0.33&quot;,
        ///       &quot;mac&quot;: &quot;00:XXXX:3e:16:7c:50&quot;,
        ///       &quot;matchedRoute&quot;: {
        ///         &quot;nextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;nodeType&quot;: &quot;ENI&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;status&quot;: &quot;InUse&quot;,
        ///       &quot;trafficLogs&quot;: [
        ///         
        ///       ]
        ///     },
        ///     {
        ///       &quot;bizInsId&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;id&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;ip&quot;: &quot;192.168.0.34&quot;,
        ///       &quot;mac&quot;: &quot;00:XXXX:3e:14:70:c2&quot;,
        ///       &quot;matchedRoute&quot;: {
        ///         &quot;nextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;nodeType&quot;: &quot;ENI&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;status&quot;: &quot;InUse&quot;,
        ///       &quot;trafficLogs&quot;: [
        ///         
        ///       ]
        ///     }
        ///   ]
        /// },
        /// &quot;reverse&quot;: {
        ///   &quot;revLinkList&quot;: [
        ///     {
        ///       &quot;id&quot;: &quot;i-wz91dk7bor557hp93zys--&gt;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;source&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;target&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;
        ///     },
        ///     {
        ///       &quot;id&quot;: &quot;eni-wz97vry93t6z4lbdgmfi--&gt;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;source&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;target&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;
        ///     },
        ///     {
        ///       &quot;id&quot;: &quot;vsw-wz9slpwdcppwfrneebcrp--&gt;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;source&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;target&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;
        ///     },
        ///     {
        ///       &quot;id&quot;: &quot;eni-wz92ce4saz1jzazgi13d--&gt;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;source&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;target&quot;: &quot;i-wz91dk7bor557hp9****&quot;
        ///     }
        ///   ],
        ///   &quot;revNodeList&quot;: [
        ///     {
        ///       &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///       &quot;bizInsId&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;id&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;level&quot;: 1,
        ///       &quot;nodeType&quot;: &quot;VM&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;revMatchedRoute&quot;: {
        ///         &quot;revNextHopSet&quot;: [
        ///           
        ///         ]
        ///       }
        ///     },
        ///     {
        ///       &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///       &quot;bizInsId&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;id&quot;: &quot;i-wz91dk7bor557hp9****&quot;,
        ///       &quot;level&quot;: 3,
        ///       &quot;nodeType&quot;: &quot;VM&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;revMatchedRoute&quot;: {
        ///         &quot;revNextHopSet&quot;: [
        ///           
        ///         ]
        ///       }
        ///     },
        ///     {
        ///       &quot;aZone&quot;: &quot;cn-shenzhen-d&quot;,
        ///       &quot;bizInsId&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;cidr&quot;: &quot;192.168.0.0/24&quot;,
        ///       &quot;id&quot;: &quot;vsw-wz9slpwdcppwfrnee****&quot;,
        ///       &quot;level&quot;: 2,
        ///       &quot;nodeType&quot;: &quot;VSW&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;revMatchedRoute&quot;: {
        ///         &quot;revNextHopSet&quot;: [
        ///           
        ///         ]
        ///       }
        ///     },
        ///     {
        ///       &quot;bizInsId&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;id&quot;: &quot;eni-wz97vry93t6z4lbd****&quot;,
        ///       &quot;ip&quot;: &quot;192.168.0.34&quot;,
        ///       &quot;mac&quot;: &quot;00:XXXX:3e:14:70:c2&quot;,
        ///       &quot;nodeType&quot;: &quot;ENI&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;revMatchedRoute&quot;: {
        ///         &quot;revNextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;status&quot;: &quot;InUse&quot;
        ///     },
        ///     {
        ///       &quot;bizInsId&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;id&quot;: &quot;eni-wz92ce4saz1jzazg****&quot;,
        ///       &quot;ip&quot;: &quot;192.168.0.33&quot;,
        ///       &quot;mac&quot;: &quot;00:XXXX:3e:16:7c:50&quot;,
        ///       &quot;nodeType&quot;: &quot;ENI&quot;,
        ///       &quot;regionNo&quot;: &quot;cn-shenzhen-st3-a01&quot;,
        ///       &quot;regionNoAlias&quot;: &quot;cn-shenzhen&quot;,
        ///       &quot;revMatchedRoute&quot;: {
        ///         &quot;revNextHopSet&quot;: [
        ///           
        ///         ]
        ///       },
        ///       &quot;status&quot;: &quot;InUse&quot;
        ///     }
        ///   ]
        /// },
        /// &quot;topologyReportId&quot;: &quot;tpr-21cf60002715491b8****&quot;
        /// </c></pre>
        /// <para>  }
        /// }</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisResult")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisResult { get; set; }

        /// <summary>
        /// <para>The state of the task for analyzing network reachability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: The task is in progress.</description></item>
        /// <item><description><b>finish</b>: The task is complete.</description></item>
        /// <item><description><b>error</b>: An analysis error occurred.</description></item>
        /// <item><description><b>timeout</b>: The task timed out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("NetworkReachableAnalysisStatus")]
        [Validation(Required=false)]
        public string NetworkReachableAnalysisStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the network path is reachable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The network path is reachable.</description></item>
        /// <item><description><b>false</b>: The network path is unreachable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reachable")]
        [Validation(Required=false)]
        public bool? Reachable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEE0FEAF-59AE-5CDD-AA07-626BC365D571</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
