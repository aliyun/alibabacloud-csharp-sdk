// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call is successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, <c>success</c> is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60912C8D-B340-4253-ADE7-61ACDFD25CFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: True: The call is successful. false: The call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The details of the event.</para>
        /// </summary>
        [NameInMap("SystemEvents")]
        [Validation(Required=false)]
        public DescribeSystemEventAttributeResponseBodySystemEvents SystemEvents { get; set; }
        public class DescribeSystemEventAttributeResponseBodySystemEvents : TeaModel {
            [NameInMap("SystemEvent")]
            [Validation(Required=false)]
            public List<DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent> SystemEvent { get; set; }
            public class DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent : TeaModel {
                /// <summary>
                /// <para>The details of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;product&quot;:&quot;CloudMonitor&quot;,&quot;content&quot;:&quot;{\&quot;ipGroup\&quot;:\&quot;112.126.XX.XX,10.163.XX.XX\&quot;,\&quot;tianjimonVersion\&quot;:\&quot;1.2.22\&quot;}&quot;,&quot;groupId&quot;:&quot;176,177,178,179,180,692,120812,1663836,96,2028302&quot;,&quot;time&quot;:&quot;1552209568000&quot;,&quot;resourceId&quot;:&quot;acs:ecs:cn-beijing:173651113438****:instance/i-25k35****&quot;,&quot;level&quot;:&quot;CRITICAL&quot;,&quot;status&quot;:&quot;stopped&quot;,&quot;instanceName&quot;:&quot;cmssiteprobebj-6&quot;,&quot;name&quot;:&quot;Agent_Status_Stopped&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;}]</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b936efc9-f621-4e8a-a6eb-076be40e****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId1</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The level of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CRITICAL</description></item>
                /// <item><description>WARN</description></item>
                /// <item><description>INFO</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WARN</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent_Status_Stopped</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The abbreviation of the service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudMonitor</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

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
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxx-1</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The status of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the event occurred. The value is a timestamp.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552199984000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

    }

}
