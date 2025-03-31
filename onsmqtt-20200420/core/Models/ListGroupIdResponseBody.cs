// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of a queried group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGroupIdResponseBodyData> Data { get; set; }
        public class ListGroupIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564577317000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The queried group that belongs to the ApsaraMQ for MQTT instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test1</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether a separate namespace is configured for the ApsaraMQ for MQTT instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A separate namespace is configured for the ApsaraMQ for MQTT instance. Resource names must be unique within an ApsaraMQ for MQTT instance but can be the same across ApsaraMQ for MQTT instances.</description></item>
            /// <item><description><b>false</b>: No separate namespace is configured for the ApsaraMQ for MQTT instance. Resource names must be globally unique within an ApsaraMQ for MQTT instance and across ApsaraMQ for MQTT instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraMQ for MQTT instance to which the group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>post-cn-45910tj****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListGroupIdResponseBodyDataTags> Tags { get; set; }
            public class ListGroupIdResponseBodyDataTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The time when the group was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564577317000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95996EEB-D894-44FA-A87C-940F5CD9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
