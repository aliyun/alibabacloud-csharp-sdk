// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public GetResourceTypeResponseBodyResourceType ResourceType { get; set; }
        public class GetResourceTypeResponseBodyResourceType : TeaModel {
            /// <summary>
            /// <para>The properties that are specific to the create operation. You need to specify these properties when you create the resource. These properties are not returned when you query the resource.</para>
            /// </summary>
            [NameInMap("createOnlyProperties")]
            [Validation(Required=false)]
            public List<string> CreateOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that are specific to the delete operation. You need to specify these properties when you delete the resource. These properties are not returned when you query the resource.</para>
            /// </summary>
            [NameInMap("deleteOnlyProperties")]
            [Validation(Required=false)]
            public List<string> DeleteOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that can be used to filter the resource when you list the resource.</para>
            /// </summary>
            [NameInMap("filterProperties")]
            [Validation(Required=false)]
            public List<string> FilterProperties { get; set; }

            /// <summary>
            /// <para>The properties that are specific to the query operation. You need to specify these properties when you query the resource. These properties are not returned in the query result.</para>
            /// </summary>
            [NameInMap("getOnlyProperties")]
            [Validation(Required=false)]
            public List<string> GetOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that are returned when you query the resource.</para>
            /// </summary>
            [NameInMap("getResponseProperties")]
            [Validation(Required=false)]
            public List<string> GetResponseProperties { get; set; }

            /// <summary>
            /// <para>The information about the operation, including the required Resource Access Management (RAM) permissions.</para>
            /// </summary>
            [NameInMap("handlers")]
            [Validation(Required=false)]
            public GetResourceTypeResponseBodyResourceTypeHandlers Handlers { get; set; }
            public class GetResourceTypeResponseBodyResourceTypeHandlers : TeaModel {
                /// <summary>
                /// <para>The information about the create operation.</para>
                /// </summary>
                [NameInMap("create")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersCreate Create { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersCreate : TeaModel {
                    /// <summary>
                    /// <para>The information about the required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information about the delete operation.</para>
                /// </summary>
                [NameInMap("delete")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersDelete Delete { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersDelete : TeaModel {
                    /// <summary>
                    /// <para>The information about the required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information about the query operation.</para>
                /// </summary>
                [NameInMap("get")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersGet Get { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersGet : TeaModel {
                    /// <summary>
                    /// <para>The information about the required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information about the list operation.</para>
                /// </summary>
                [NameInMap("list")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersList List { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersList : TeaModel {
                    /// <summary>
                    /// <para>The information about the required RAM permissions.</para>
                    /// </summary>
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                /// <summary>
                /// <para>The information about the update operation.</para>
                /// </summary>
                [NameInMap("update")]
                [Validation(Required=false)]
                public GetResourceTypeResponseBodyResourceTypeHandlersUpdate Update { get; set; }
                public class GetResourceTypeResponseBodyResourceTypeHandlersUpdate : TeaModel {
                    /// <summary>
                    /// <para>The information about the required RAM permissions.</para>
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
                /// <para>The payment form. Valid values:</para>
                /// <para>paid free</para>
                /// 
                /// <b>Example:</b>
                /// <para>paid</para>
                /// </summary>
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The delivery level. Valid values:</para>
                /// <para>center</para>
                /// <para>region</para>
                /// <para>zone</para>
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
            /// <para>The properties that are specific to the list operation. You need to specify these properties when you list the resource. These properties are not returned when you query the resource.</para>
            /// </summary>
            [NameInMap("listOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ListOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that are returned when you list the resource.</para>
            /// </summary>
            [NameInMap("listResponseProperties")]
            [Validation(Required=false)]
            public List<string> ListResponseProperties { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/properties/InstanceId</para>
            /// </summary>
            [NameInMap("primaryIdentifier")]
            [Validation(Required=false)]
            public string PrimaryIdentifier { get; set; }

            /// <summary>
            /// <para>The code of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The resource properties. The key specifies the property name and the value specifies the details of the property.</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>The common properties of the resource. The common properties are not operation-specific.</para>
            /// </summary>
            [NameInMap("publicProperties")]
            [Validation(Required=false)]
            public List<string> PublicProperties { get; set; }

            /// <summary>
            /// <para>The read-only properties. These properties are returned only when you perform the List or Get operation. You do not need to specify these properties when you create or update the resource.</para>
            /// </summary>
            [NameInMap("readOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ReadOnlyProperties { get; set; }

            /// <summary>
            /// <para>The properties that must be specified when you create the resource.</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public List<string> Required { get; set; }

            /// <summary>
            /// <para>The type of the resource. If the resource belongs to a parent resource, the return format is {parent resource type code /resource type code}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The sensitive properties, such as the password.</para>
            /// </summary>
            [NameInMap("sensitiveInfoProperties")]
            [Validation(Required=false)]
            public List<string> SensitiveInfoProperties { get; set; }

            /// <summary>
            /// <para>The properties that are specific to the update operation. You need to specify these properties when you update the resource. These properties are not returned when you query the resource.</para>
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
