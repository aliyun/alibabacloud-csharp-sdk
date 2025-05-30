// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class AddFCTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogFileCreated</para>
        /// </summary>
        [NameInMap("EventMetaName")]
        [Validation(Required=false)]
        public string EventMetaName { get; set; }

        /// <summary>
        /// <para>The version of the event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("EventMetaVersion")]
        [Validation(Required=false)]
        public string EventMetaVersion { get; set; }

        /// <summary>
        /// <para>The feature trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:1223455566666:123:services/myservice/functions/myfunction</para>
        /// </summary>
        [NameInMap("FunctionARN")]
        [Validation(Required=false)]
        public string FunctionARN { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The assigned Resource Access Management (RAM) role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram:: 1234567890:role/aliyuncdneventnotificationrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The resources and filters for event listening.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:cdn:*:1234567890:domain/example.com</para>
        /// </summary>
        [NameInMap("SourceARN")]
        [Validation(Required=false)]
        public string SourceARN { get; set; }

        /// <summary>
        /// <para>The trigger that corresponds to the Function Compute service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-beijing: 1234567890:services/FCTestService/functions/printEvent/triggers/testtrigger</para>
        /// </summary>
        [NameInMap("TriggerARN")]
        [Validation(Required=false)]
        public string TriggerARN { get; set; }

    }

}
