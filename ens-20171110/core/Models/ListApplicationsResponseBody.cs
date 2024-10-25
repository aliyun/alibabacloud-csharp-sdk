// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyApplications Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyApplicationsApplication> Application { get; set; }
            public class ListApplicationsResponseBodyApplicationsApplication : TeaModel {
                /// <summary>
                /// <para>Details about the application.</para>
                /// </summary>
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public ListApplicationsResponseBodyApplicationsApplicationAppList AppList { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationAppList : TeaModel {
                    [NameInMap("App")]
                    [Validation(Required=false)]
                    public List<ListApplicationsResponseBodyApplicationsApplicationAppListApp> App { get; set; }
                    public class ListApplicationsResponseBodyApplicationsApplicationAppListApp : TeaModel {
                        /// <summary>
                        /// <para>The ID of the application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e76f8985-7965-41fc-925b-9648bb6bf650</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The information about the application, such as the resource specification, parameter configuration, and resources.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///     &quot;AppStatus&quot;:{
                        ///         &quot;Phase&quot;:&quot;RUNNING&quot;,
                        ///         &quot;StatusDescrip&quot;:&quot;{\&quot;status\&quot;:\&quot;UPDATE_SUCCESS\&quot;,\&quot;step\&quot;:\&quot;DONE\&quot;,\&quot;descrip\&quot;:\&quot;update to version:1022 success\&quot;,\&quot;start_time\&quot;:\&quot;2022-03-01 16:18:22\&quot;}&quot;,
                        ///         &quot;UpdateTime&quot;:&quot;2022-03-01 16:18:22&quot;,
                        ///         &quot;OrderStatus&quot;:null
                        ///     },
                        ///     &quot;ResourceAttribute&quot;:{
                        ///         &quot;NetSecurityInfo&quot;:null,
                        ///         &quot;InitConfig&quot;:null,
                        ///         &quot;InventoryType&quot;:&quot;Ens&quot;,
                        ///         &quot;InstanceSpec&quot;:&quot;ens.gi6s-c12g1.large&quot;,
                        ///         &quot;SystemDiskSize&quot;:100,
                        ///         &quot;DataDiskSize&quot;:0,
                        ///         &quot;BandwithOut&quot;:5000,
                        ///         &quot;SchedulingStrategy&quot;:&quot;Disperse&quot;,
                        ///         &quot;ImageId&quot;:&quot;m-5or73kzkuxytv7hh6wxr6yc5q&quot;,
                        ///         &quot;ResourceType&quot;:&quot;Linux&quot;,
                        ///         &quot;AreaLevel&quot;:&quot;National&quot;,
                        ///         &quot;IpType&quot;:&quot;PublicIP&quot;
                        ///     },
                        ///     &quot;WorkloadAttribute&quot;:[
                        ///         {
                        ///             &quot;Name&quot;:&quot;andorid&quot;,
                        ///             &quot;Count&quot;:15,
                        ///             &quot;ServiceConfig&quot;:{
                        ///                 &quot;PortsBindConfig&quot;:{
                        ///                     &quot;NetServiceContainer&quot;:&quot;uravi-service&quot;,
                        ///                     &quot;Ports&quot;:[
                        ///                         {
                        ///                             &quot;Protocol&quot;:&quot;TCP&quot;,
                        ///                             &quot;BindType&quot;:&quot;Mapping&quot;,
                        ///                             &quot;StartNodePorts&quot;:&quot;31000-31009&quot;,
                        ///                             &quot;ContainerPorts&quot;:&quot;4440-4449&quot;
                        ///                         },
                        ///                         {
                        ///                             &quot;Protocol&quot;:&quot;TCP&quot;,
                        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
                        ///                             &quot;StartNodePorts&quot;:&quot;59000-59000&quot;,
                        ///                             &quot;ContainerPorts&quot;:&quot;59000-59000&quot;
                        ///                         },
                        ///                         {
                        ///                             &quot;Protocol&quot;:&quot;UDP&quot;,
                        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
                        ///                             &quot;StartNodePorts&quot;:&quot;40001-40010&quot;,
                        ///                             &quot;ContainerPorts&quot;:&quot;40001-40010&quot;
                        ///                         }
                        ///                     ]
                        ///                 },
                        ///                 &quot;ServiceContainerName&quot;:&quot;android&quot;
                        ///             }
                        ///         },
                        ///         {
                        ///             &quot;Name&quot;:&quot;coturn&quot;,
                        ///             &quot;Count&quot;:1,
                        ///             &quot;ServiceConfig&quot;:{
                        ///                 &quot;PortsBindConfig&quot;:{
                        ///                     &quot;NetServiceContainer&quot;:&quot;coturn&quot;,
                        ///                     &quot;Ports&quot;:[
                        ///                         {
                        ///                             &quot;Protocol&quot;:&quot;TCP&quot;,
                        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
                        ///                             &quot;StartNodePorts&quot;:&quot;3478-3478&quot;,
                        ///                             &quot;ContainerPorts&quot;:&quot;3478-3478&quot;
                        ///                         },
                        ///                         {
                        ///                             &quot;Protocol&quot;:&quot;UDP&quot;,
                        ///                             &quot;BindType&quot;:&quot;PassThrough&quot;,
                        ///                             &quot;StartNodePorts&quot;:&quot;3478-3478&quot;,
                        ///                             &quot;ContainerPorts&quot;:&quot;3478-3478&quot;
                        ///                         }
                        ///                     ]
                        ///                 },
                        ///                 &quot;ServiceContainerName&quot;:&quot;coturn&quot;
                        ///             }
                        ///         },
                        ///         {
                        ///             &quot;Name&quot;:&quot;aic-manager&quot;,
                        ///             &quot;Count&quot;:1,
                        ///             &quot;ServiceConfig&quot;:null
                        ///         }
                        ///     ]
                        /// }</para>
                        /// </summary>
                        [NameInMap("AppInfo")]
                        [Validation(Required=false)]
                        public string AppInfo { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ay-ads-hz-h</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>50373E71-7710-4620-8AAB-133CCE49451C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
