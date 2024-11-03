// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeFCTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The Function Compute trigger that you want to query.</para>
        /// </summary>
        [NameInMap("FCTrigger")]
        [Validation(Required=false)]
        public DescribeFCTriggerResponseBodyFCTrigger FCTrigger { get; set; }
        public class DescribeFCTriggerResponseBodyFCTrigger : TeaModel {
            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LogFileCreated</para>
            /// </summary>
            [NameInMap("EventMetaName")]
            [Validation(Required=false)]
            public string EventMetaName { get; set; }

            /// <summary>
            /// <para>The version of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("EventMetaVersion")]
            [Validation(Required=false)]
            public string EventMetaVersion { get; set; }

            /// <summary>
            /// <para>The remarks of the Function Compute trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public string Notes { get; set; }

            /// <summary>
            /// <para>The assigned Resource Access Management (RAM) role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram:: 1234567890:role/aliyuncdneventnotificationrole</para>
            /// </summary>
            [NameInMap("RoleARN")]
            [Validation(Required=false)]
            public string RoleARN { get; set; }

            /// <summary>
            /// <para>The resources and filters for event listening.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:cdn:*:1234567890:domain/example.com</para>
            /// </summary>
            [NameInMap("SourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

            /// <summary>
            /// <para>The trigger that corresponds to the Function Compute service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-beijing: 1234567890:services/FCTestService/functions/printEvent/triggers/testtrigger</para>
            /// </summary>
            [NameInMap("TriggerARN")]
            [Validation(Required=false)]
            public string TriggerARN { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC046C5D-8CB4-4B6B-B7F8-B335E51EF90E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
