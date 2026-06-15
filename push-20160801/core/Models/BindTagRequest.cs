// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class BindTagRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of your application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The ID of the target device. You can specify a maximum of 1,000 device IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2ba19de97604f55b16557673****</para>
        /// </summary>
        [NameInMap("ClientKey")]
        [Validation(Required=false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// <para>The type of the <c>ClientKey</c>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>DEVICE</b>: Indicates a device target.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE</para>
        /// </summary>
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        /// <summary>
        /// <para>The tags to bind. Separate multiple tags with commas (,). You can bind up to 10 tags per request.
        /// A tag name can be up to 128 characters long (each Chinese character counts as 1 character). Each application can have up to 10,000 tags. A single device can be bound to multiple tags.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Do not bind a single tag to more than 100,000 devices. This practice can increase push processing time and increase response time.</para>
        /// <list type="bullet">
        /// <item><description><para>Use the full push feature to send notifications to all devices.</para>
        /// </description></item>
        /// <item><description><para>Split the device set into multiple fine-grained tags and call the push API in batches.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you attempt to bind the same tag multiple times, the system automatically removes the duplicates.</para>
        /// </description></item>
        /// <item><description><para>When a user uninstalls the application from a device, the tags associated with that device are automatically unbound. This unbinding process may be slightly delayed.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tag,test_tag2</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
