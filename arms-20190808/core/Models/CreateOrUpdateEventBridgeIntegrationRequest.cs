// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateEventBridgeIntegrationRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID that is used to connect to EventBridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc******************</para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The AccessKey secret that is used to connect to EventBridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc******************</para>
        /// </summary>
        [NameInMap("AccessSecret")]
        [Validation(Required=false)]
        public string AccessSecret { get; set; }

        /// <summary>
        /// <para>The description of the EventBridge integration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The public endpoint of EventBridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxx">http://xxxxx</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The name of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBus_Test</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The region ID of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EventBusRegionId")]
        [Validation(Required=false)]
        public string EventBusRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the EventBridge integration.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, an EventBridge integration is created.</description></item>
        /// <item><description>If you specify this parameter, the specified EventBridge integration is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the EventBridge integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBridge_Test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
