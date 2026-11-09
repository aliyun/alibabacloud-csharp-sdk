// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the returned group IDs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGroupIdResponseBodyData> Data { get; set; }
        public class ListGroupIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation timestamp of the group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564577317000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test1</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has an independent namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance has an independent namespace. In this case, resource names must be unique within the instance, but they can be the same as resource names in other instances.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance does not have an independent namespace. In this case, resource names must be globally unique across all instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the group ID belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>post-cn-45910tj****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The tags attached to the group ID.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListGroupIdResponseBodyDataTags> Tags { get; set; }
            public class ListGroupIdResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The timestamp of the last update for the group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564577317000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The unique ID for the request. This is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95996EEB-D894-44FA-A87C-940F5CD9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
