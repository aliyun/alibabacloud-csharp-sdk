// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class SendDryRunSystemEventRequest : TeaModel {
        /// <summary>
        /// <para>The content of the system event.</para>
        /// <remarks>
        /// <para> The value of this parameter is a JSON object. We recommend that you include the <c>product</c>, <c>resourceId</c>, and <c>regionId</c> fields in the JSON object.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;product&quot;:&quot;CloudMonitor&quot;,&quot;resourceId&quot;:&quot;acs:ecs:cn-hongkong:173651113438****:instance/{instanceId}&quot;,&quot;level&quot;:&quot;CRITICAL&quot;,&quot;instanceName&quot;:&quot;instanceName&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;name&quot;:&quot;Agent_Status_Stopped&quot;,&quot;content&quot;:{&quot;ipGroup&quot;:&quot;0.0.0.0,0.0.0.1&quot;,&quot;tianjimonVersion&quot;:&quot;1.2.11&quot;},&quot;status&quot;:&quot;stopped&quot;}</para>
        /// </summary>
        [NameInMap("EventContent")]
        [Validation(Required=false)]
        public string EventContent { get; set; }

        /// <summary>
        /// <para>The name of the system event.</para>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent_Status_Stopped</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the cloud service.</para>
        /// <remarks>
        /// <para> For information about the system events supported by Cloud Monitor for Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/167388.html">System events</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
