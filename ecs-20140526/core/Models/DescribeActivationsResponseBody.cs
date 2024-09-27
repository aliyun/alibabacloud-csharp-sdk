// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeActivationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The activation codes and their usage information.</para>
        /// </summary>
        [NameInMap("ActivationList")]
        [Validation(Required=false)]
        public List<DescribeActivationsResponseBodyActivationList> ActivationList { get; set; }
        public class DescribeActivationsResponseBodyActivationList : TeaModel {
            /// <summary>
            /// <para>The ID of the activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ECEEE12-56F1-4FBC-9AB1-890F1234****</para>
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// <para>The time when the activation code was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T06:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The number of instances that were deregistered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DeregisteredCount")]
            [Validation(Required=false)]
            public int? DeregisteredCount { get; set; }

            /// <summary>
            /// <para>The description of the activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the activation code is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The maximum number of times that the activation code can be used to register managed instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The default instance name prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-InstanceName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The IP addresses of hosts that are allowed to use the activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("IpAddressRange")]
            [Validation(Required=false)]
            public string IpAddressRange { get; set; }

            /// <summary>
            /// <para>The number of instances that were registered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RegisteredCount")]
            [Validation(Required=false)]
            public int? RegisteredCount { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the activation code belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags of the activation code.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeActivationsResponseBodyActivationListTags> Tags { get; set; }
            public class DescribeActivationsResponseBodyActivationListTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>owner</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The validity period of the activation code. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TimeToLiveInHours")]
            [Validation(Required=false)]
            public long? TimeToLiveInHours { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F74625134</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
