// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No parent resource:
        /// Instance
        /// Has parent resource:
        /// DBInstance/Account</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public GetResourceTypeResponseBodyResourceType ResourceType { get; set; }
        public class GetResourceTypeResponseBodyResourceType : TeaModel {
            /// <summary>
            /// <para>The properties exclusive to the create operation. These properties are not returned in resource query operations but are required as input parameters for the create operation.</para>
            /// </summary>
            [NameInMap("createOnlyProperties")]
            [Validation(Required=false)]
            public List<string> CreateOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties exclusive to the delete operation. These properties are not returned in resource query operations but are required as input parameters for the delete operation.</para>
            /// </summary>
            [NameInMap("deleteOnlyProperties")]
            [Validation(Required=false)]
            public List<string> DeleteOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that can be used as filter parameters in the list operation.</para>
            /// </summary>
            [NameInMap("filterProperties")]
            [Validation(Required=false)]
            public List<string> FilterProperties { get; set; }

            /// <summary>
            /// <para>The properties exclusive to the get operation. These properties are not returned in resource query operations but are required as input parameters for the get operation.</para>
            /// </summary>
            [NameInMap("getOnlyProperties")]
            [Validation(Required=false)]
            public List<string> GetOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties returned by the get operation.</para>
            /// </summary>
            [NameInMap("getResponseProperties")]
            [Validation(Required=false)]
            public List<string> GetResponseProperties { get; set; }

            /// <summary>
            /// <para>The supported resource operations, including RAM permissions.</para>
            /// </summary>
            [NameInMap("handlers")]
            [Validation(Required=false)]
            public GetResourceTypeResponseBodyResourceTypeHandlers Handlers { get; set; }
            public class GetResourceTypeResponseBodyResourceTypeHandlers : TeaModel {
                /// <summary>
                /// <para>The information associated with the create operation.</para>
                /// </summary>
                [NameInMap("create")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersCreate Create { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersCreate : TeaModel {
                    /// <summary>
                    /// <para>The required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information associated with the delete operation.</para>
                /// </summary>
                [NameInMap("delete")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersDelete Delete { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersDelete : TeaModel {
                    /// <summary>
                    /// <para>The required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information associated with the get operation.</para>
                /// </summary>
                [NameInMap("get")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersGet Get { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersGet : TeaModel {
                    /// <summary>
                    /// <para>The required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information associated with the list operation.</para>
                /// </summary>
                [NameInMap("list")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersList List { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersList : TeaModel {
                    /// <summary>
                    /// <para>The required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information associated with the update operation.</para>
                /// </summary>
                [NameInMap("update")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersUpdate Update { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersUpdate : TeaModel {
                    /// <summary>
                    /// <para>The required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

            }

            /// <summary>
            /// <para>The basic information about the resource type.</para>
            /// </summary>
            [NameInMap("info")]
            [Validation(Required=false)]
            public GetResourceTypeResponseBodyResourceTypeInfo Info { get; set; }
            public class GetResourceTypeResponseBodyResourceTypeInfo : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <para>paid: paid.</para>
                /// <para>free: free.</para>
                /// 
                /// <b>Example:</b>
                /// <para>paid</para>
                /// </summary>
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The delivery scope. Valid values: </para>
                /// <para>center: centralized deployment.</para>
                /// <para>region: region-level deployment.</para>
                /// <para>zone: zone-level deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("deliveryScope")]
                [Validation(Required=false)]
                public string DeliveryScope { get; set; }

                /// <summary>
                /// <para>The description of the resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An ECS instance is equivalent to a virtual machine, including the most basic computing components such as CPU, memory, operating system, network, and disk. You can easily customize and change the configuration of the instance. You have full control over the virtual machine.</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The properties exclusive to the list operation. These properties are not returned in resource query operations but are required as input parameters for the list operation.</para>
            /// </summary>
            [NameInMap("listOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ListOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties returned by the list operation.</para>
            /// </summary>
            [NameInMap("listResponseProperties")]
            [Validation(Required=false)]
            public List<string> ListResponseProperties { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/properties/InstanceId</para>
            /// </summary>
            [NameInMap("primaryIdentifier")]
            [Validation(Required=false)]
            public string PrimaryIdentifier { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The resource property definitions. The key is the property name, and the value is the detailed property information.</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>The common properties that represent basic resource attributes. These are not operation-specific properties.</para>
            /// </summary>
            [NameInMap("publicProperties")]
            [Validation(Required=false)]
            public List<string> PublicProperties { get; set; }

            /// <summary>
            /// <para>The read-only properties. These properties are returned only in list or get operations and cannot be used as input parameters for create or update operations.</para>
            /// </summary>
            [NameInMap("readOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ReadOnlyProperties { get; set; }

            /// <summary>
            /// <para>The required parameters for resource creation.</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public List<string> Required { get; set; }

            /// <summary>
            /// <para>The resource type. If the resource has a parent resource, the format is {parentResourceTypeCode/resourceTypeCode}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无父资源：
            /// Instance
            /// 有父资源：
            /// DBInstance/Account</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The sensitive properties, such as passwords.</para>
            /// </summary>
            [NameInMap("sensitiveInfoProperties")]
            [Validation(Required=false)]
            public List<string> SensitiveInfoProperties { get; set; }

            /// <summary>
            /// <para>The properties exclusive to the update operation. These properties are not returned in resource query operations but are required as input parameters for the update operation.</para>
            /// </summary>
            [NameInMap("updateOnlyProperties")]
            [Validation(Required=false)]
            public List<string> UpdateOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that can be modified.</para>
            /// </summary>
            [NameInMap("updateTypeProperties")]
            [Validation(Required=false)]
            public List<string> UpdateTypeProperties { get; set; }

        }

    }

}
