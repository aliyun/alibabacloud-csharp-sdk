// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about the queried instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceInServiceListResponseBodyData Data { get; set; }
        public class OnsInstanceInServiceListResponseBodyData : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<OnsInstanceInServiceListResponseBodyDataInstanceVO> InstanceVO { get; set; }
            public class OnsInstanceInServiceListResponseBodyDataInstanceVO : TeaModel {
                /// <summary>
                /// <para>The time when the instance was created. The value of this parameter is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640847284000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The number of consumer groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                /// <summary>
                /// <para>Indicates whether a namespace is used for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: A separate namespace is used for the instance. The identifier of each resource in the instance must be unique within the instance. However, the identifier of a resource in the instance can be the same as the identifier of a resource in another instance that uses a different namespace.</description></item>
                /// <item><description><b>false</b>: A separate namespace is not used for the instance. The name of each resource must be globally unique within the instance and across all instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MQ_INST_188077086902****_BXSuW61e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// <para>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The instance is being deployed. This value is valid only for Enterprise Platinum Edition instances.</description></item>
                /// <item><description><b>2</b>: The instance has overdue payments. This value is valid only for Standard Edition instances.</description></item>
                /// <item><description><b>5</b>: The instance is running. This value is valid only for Standard Edition instances and Enterprise Platinum Edition instances.</description></item>
                /// <item><description><b>7</b>: The instance is being upgraded and is running. This value is valid only for Enterprise Platinum Edition instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public int? InstanceStatus { get; set; }

                /// <summary>
                /// <para>The instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Standard Edition</description></item>
                /// <item><description><b>2</b>: Enterprise Platinum Edition</description></item>
                /// </list>
                /// <para>For information about the instance editions and the differences between the editions, see <a href="https://help.aliyun.com/document_detail/185261.html">Instance editions</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                /// <summary>
                /// <para>The time when the instance expires. If the instance is of Enterprise Platinum Edition, this parameter is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1551024000000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <para>The tags that are attached to the instance.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsInstanceInServiceListResponseBodyDataInstanceVOTags Tags { get; set; }
                public class OnsInstanceInServiceListResponseBodyDataInstanceVOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag> Tag { get; set; }
                    public class OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CartService</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ServiceA</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of topics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TopicCount")]
                [Validation(Required=false)]
                public int? TopicCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0598E46F-DB06-40E2-AD7B-C45923EE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
