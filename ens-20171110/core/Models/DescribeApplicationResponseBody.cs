// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned application information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;AppMetaData&quot;:{
        ///         &quot;AppId&quot;:&quot;b0b27670-87d5-4c40-9ea8-adeeec2986ce&quot;,
        ///         &quot;AppName&quot;:&quot;asp-yz&quot;,
        ///         &quot;ClusterName&quot;:&quot;poc&quot;,
        ///         &quot;AppStableVersion&quot;:&quot;0825&quot;,
        ///         &quot;AppType&quot;:&quot;Scheduler&quot;,
        ///         &quot;Description&quot;:&quot;Daily testing CPU environment&quot;,
        ///         &quot;CreateTime&quot;:&quot;2020-08-25 16:36:16&quot;
        ///     },
        ///     &quot;AppStatus&quot;:{
        ///         &quot;Phase&quot;:&quot;RUNNING&quot;,
        ///         &quot;StatusDescrip&quot;:&quot;{\&quot;status\&quot;:\&quot;UPDATE_SUCCESS\&quot;,\&quot;step\&quot;:\&quot;DONE\&quot;,\&quot;descrip\&quot;:\&quot;delVersion success\&quot;,\&quot;start_time\&quot;:\&quot;2021-08-18 14:46:45\&quot;}&quot;,
        ///         &quot;UpdateTime&quot;:&quot;2021-08-18 14:46:45&quot;
        ///     },
        ///     &quot;ResourceAttribute&quot;:{
        ///         &quot;ResourceType&quot;:&quot;Ens&quot;,
        ///         &quot;ResourceAgent&quot;:&quot;Linux&quot;,
        ///         &quot;InstanceSpec&quot;:&quot;ens.sn1.large&quot;,
        ///         &quot;SystemDiskSize&quot;:40,
        ///         &quot;DataDiskSize&quot;:0,
        ///         &quot;BandwithOut&quot;:10,
        ///         &quot;SchedulingStrategy&quot;:&quot;Disperse&quot;,
        ///         &quot;AreaLevel&quot;:&quot;RegionId&quot;,
        ///         &quot;IpType&quot;:&quot;PublicIP&quot;
        ///     },
        ///     &quot;WorkloadAttribute&quot;:[
        ///         {
        ///             &quot;Name&quot;:&quot;andorid&quot;,
        ///             &quot;PodCount&quot;:7,
        ///             &quot;ServiceConfig&quot;:{
        ///                 &quot;PortsBindConfig&quot;:{
        ///                     &quot;NetServiceContainer&quot;:&quot;aspserver-android&quot;,
        ///                     &quot;Ports&quot;:[
        ///                         {
        ///                             &quot;Protocol&quot;:&quot;TCP&quot;,
        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
        ///                             &quot;StartNodePorts&quot;:&quot;5000-5000&quot;,
        ///                             &quot;ContainerPorts&quot;:&quot;5000-5000&quot;
        ///                         },
        ///                         {
        ///                             &quot;Protocol&quot;:&quot;UDP&quot;,
        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
        ///                             &quot;StartNodePorts&quot;:&quot;4001-4010&quot;,
        ///                             &quot;ContainerPorts&quot;:&quot;4001-4010&quot;
        ///                         }
        ///                     ]
        ///                 },
        ///                 &quot;ServiceContainerName&quot;:&quot;android&quot;
        ///             }
        ///         },
        ///         {
        ///             &quot;Name&quot;:&quot;aic-manager&quot;,
        ///             &quot;PodCount&quot;:1,
        ///             &quot;ServiceConfig&quot;:null
        ///         }
        ///     ],
        ///     &quot;DetailStat&quot;:{
        ///         &quot;Level&quot;:&quot;Small&quot;,
        ///         &quot;InstanceTotalCount&quot;:1,
        ///         &quot;InstanceRunningCount&quot;:0,
        ///         &quot;PodCountStat&quot;:[
        ///             {
        ///                 &quot;Name&quot;:&quot;andorid&quot;,
        ///                 &quot;RunningCount&quot;:7,
        ///                 &quot;ProducedCount&quot;:7,
        ///                 &quot;Devices&quot;:null
        ///             },
        ///             {
        ///                 &quot;Name&quot;:&quot;aic-manager&quot;,
        ///                 &quot;RunningCount&quot;:1,
        ///                 &quot;ProducedCount&quot;:1,
        ///                 &quot;Devices&quot;:null
        ///             }
        ///         ],
        ///         &quot;AppVersionStat&quot;:[
        ///             {
        ///                 &quot;AppVersion&quot;:&quot;08102&quot;,
        ///                 &quot;Descrip&quot;:&quot;White Screen Test 2&quot;,
        ///                 &quot;CreateTime&quot;:&quot;2021-08-10 11:20:04&quot;,
        ///                 &quot;InstanceTotalCount&quot;:1,
        ///                 &quot;InstanceRunningCount&quot;:0,
        ///                 &quot;PodCountStat&quot;:[
        ///                     {
        ///                         &quot;Name&quot;:&quot;andorid&quot;,
        ///                         &quot;RunningCount&quot;:7,
        ///                         &quot;ProducedCount&quot;:7,
        ///                         &quot;Devices&quot;:null
        ///                     },
        ///                     {
        ///                         &quot;Name&quot;:&quot;aic-manager&quot;,
        ///                         &quot;RunningCount&quot;:1,
        ///                         &quot;ProducedCount&quot;:1,
        ///                         &quot;Devices&quot;:null
        ///                     }
        ///                 ],
        ///                 &quot;DistrictStat&quot;:[
        ///                     {
        ///                         &quot;AreaCode&quot;:&quot;310100&quot;,
        ///                         &quot;AreaName&quot;:&quot;East China,,&quot;,
        ///                         &quot;RegionCode&quot;:&quot;310100&quot;,
        ///                         &quot;RegionName&quot;:&quot;&quot;,
        ///                         &quot;IspCode&quot;:&quot;telecom&quot;,
        ///                         &quot;RegionIds&quot;:[
        ///                             &quot;cn-shanghai-telecom-2&quot;
        ///                         ],
        ///                         &quot;InstanceTotalCount&quot;:1,
        ///                         &quot;InstanceRunningCount&quot;:0,
        ///                         &quot;PodCountStat&quot;:[
        ///                             {
        ///                                 &quot;Name&quot;:&quot;andorid&quot;,
        ///                                 &quot;RunningCount&quot;:7,
        ///                                 &quot;ProducedCount&quot;:7,
        ///                                 &quot;Devices&quot;:null
        ///                             },
        ///                             {
        ///                                 &quot;Name&quot;:&quot;aic-manager&quot;,
        ///                                 &quot;RunningCount&quot;:1,
        ///                                 &quot;ProducedCount&quot;:1,
        ///                                 &quot;Devices&quot;:null
        ///                             }
        ///                         ],
        ///                         &quot;InstanceStat&quot;:[
        ///                             {
        ///                                 &quot;InstanceId&quot;:&quot;i-xxxxxxx&quot;,
        ///                                 &quot;PublicIps&quot;:[
        ///                                     {
        ///                                         &quot;PublicIp&quot;:&quot;101.227.7.12&quot;,
        ///                                         &quot;Isp&quot;:&quot;telecom&quot;
        ///                                     }
        ///                                 ],
        ///                                 &quot;InternalIps&quot;:[
        ///                                     {
        ///                                         &quot;Ip&quot;:&quot;10.0.1.4&quot;
        ///                                     }
        ///                                 ],
        ///                                 &quot;RegionId&quot;:&quot;cn-shanghai-telecom-2&quot;,
        ///                                 &quot;NcName&quot;:&quot;&quot;,
        ///                                 &quot;InstanceStatus&quot;:&quot;&quot;,
        ///                                 &quot;CreateTime&quot;:&quot;2020-09-12 22:33:08&quot;,
        ///                                 &quot;PodCountStat&quot;:[
        ///                                     {
        ///                                         &quot;Name&quot;:&quot;andorid&quot;,
        ///                                         &quot;RunningCount&quot;:7,
        ///                                         &quot;ProducedCount&quot;:7,
        ///                                         &quot;Devices&quot;:[
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-0&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-1&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-2&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-3&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-4&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-5&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             },
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-andorid-08102-zjzmcyaw-6&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             }
        ///                                         ]
        ///                                     },
        ///                                     {
        ///                                         &quot;Name&quot;:&quot;aic-manager&quot;,
        ///                                         &quot;RunningCount&quot;:1,
        ///                                         &quot;ProducedCount&quot;:1,
        ///                                         &quot;Devices&quot;:[
        ///                                             {
        ///                                                 &quot;Name&quot;:&quot;asp-yz-aic-manager-08102-zjzmcyaw-0&quot;,
        ///                                                 &quot;Status&quot;:&quot;Running&quot;,
        ///                                                 &quot;Ports&quot;:null
        ///                                             }
        ///                                         ]
        ///                                     }
        ///                                 ],
        ///                                 &quot;AppVersionDescrip&quot;:&quot;&quot;
        ///                             }
        ///                         ]
        ///                     }
        ///                 ]
        ///             }
        ///         ]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public string Application { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
