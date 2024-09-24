// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeUnhealthyHostAvailabilityResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACBDBB40-DFB6-4F4C-8957-51FFB233969C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The unhealthy instances that are detected by the specified availability monitoring tasks.</para>
        /// </summary>
        [NameInMap("UnhealthyList")]
        [Validation(Required=false)]
        public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList UnhealthyList { get; set; }
        public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList : TeaModel {
            [NameInMap("NodeTaskInstance")]
            [Validation(Required=false)]
            public List<DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance> NodeTaskInstance { get; set; }
            public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance : TeaModel {
                /// <summary>
                /// <para>The ID of the availability monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The unhealthy instances that are detected by the availability monitoring task.</para>
                /// </summary>
                [NameInMap("InstanceList")]
                [Validation(Required=false)]
                public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList InstanceList { get; set; }
                public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList : TeaModel {
                    [NameInMap("String")]
                    [Validation(Required=false)]
                    public List<string> String { get; set; }

                }

            }

        }

    }

}
