// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acc20240402.Models
{
    public class GetImageCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the image cache was created, in ISO 8601 format and UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-**-**T07:55:25Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The events of the image cache.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetImageCacheResponseBodyEvents> Events { get; set; }
        public class GetImageCacheResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The number of times the event was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The time when the event first occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-**-**T02:24:48Z</para>
            /// </summary>
            [NameInMap("FirstTimestamp")]
            [Validation(Required=false)]
            public string FirstTimestamp { get; set; }

            /// <summary>
            /// <para>The time when the event last occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-**-**T02:24:48Z</para>
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public string LastTimestamp { get; set; }

            /// <summary>
            /// <para>The event message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image cache [my-imc] has been created successfully</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imagetest.1661f31f851*****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cause of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImageCacheCreated</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The image cache ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-bp1dj*****</para>
        /// </summary>
        [NameInMap("ImageCacheId")]
        [Validation(Required=false)]
        public string ImageCacheId { get; set; }

        /// <summary>
        /// <para>The name of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-imc</para>
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// <para>The names of the container images in the image cache.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The network configurations for pulling images when the image cache is created.</para>
        /// </summary>
        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public GetImageCacheResponseBodyNetworkConfig NetworkConfig { get; set; }
        public class GetImageCacheResponseBodyNetworkConfig : TeaModel {
            /// <summary>
            /// <para>The configurations of the elastic IP address (EIP) instance.</para>
            /// </summary>
            [NameInMap("EipInstance")]
            [Validation(Required=false)]
            public GetImageCacheResponseBodyNetworkConfigEipInstance EipInstance { get; set; }
            public class GetImageCacheResponseBodyNetworkConfigEipInstance : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically create an EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoCreate")]
                [Validation(Required=false)]
                public bool? AutoCreate { get; set; }

                /// <summary>
                /// <para>The bandwidth of the automatically created EIP. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The elastic IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-0jl0bx3fnpnjc9i4*****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-0jlgektkddwa42n*****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The platform type of the image cache. Valid values: linux/amd64 and windows/amd64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows/amd64</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The time when the image cache becomes active, in ISO 8601 format and UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-**-**T07:58:25Z</para>
        /// </summary>
        [NameInMap("ReadyTime")]
        [Validation(Required=false)]
        public string ReadyTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E234675-3465-4CC3-9D0F-9A864BC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzh43v*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The size of the image cache. Unit: GiB. Minimum value: 1 GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The status of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the image cache. Up to 20 tags are supported.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetImageCacheResponseBodyTags> Tags { get; set; }
        public class GetImageCacheResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The image cache type. Valid values: <c>General</c>, <c>Base</c>, and <c>Derived</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
