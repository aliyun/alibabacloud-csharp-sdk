// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The Function Compute triggers that are set for Alibaba Cloud CDN events.</para>
        /// </summary>
        [NameInMap("FCTriggers")]
        [Validation(Required=false)]
        public List<ListFCTriggerResponseBodyFCTriggers> FCTriggers { get; set; }
        public class ListFCTriggerResponseBodyFCTriggers : TeaModel {
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
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public string Notes { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) role.</para>
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
