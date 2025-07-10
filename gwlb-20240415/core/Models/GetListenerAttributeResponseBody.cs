// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The listener description.</para>
        /// <para>The description must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>listener_description</para>
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// <para>The listener ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-3kbj3587mqhm3p****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The listener status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Provisioning</b>: The listener is being created.</description></item>
        /// <item><description><b>Running</b>: The listener is running.</description></item>
        /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
        /// <item><description><b>Deleting</b>: The listener is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Provisioning</para>
        /// </summary>
        [NameInMap("ListenerStatus")]
        [Validation(Required=false)]
        public string ListenerStatus { get; set; }

        /// <summary>
        /// <para>The GWLB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gwlb-te609d6696632f76****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The region ID of the GWLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75CC3312-7757-5EE1-90D8-49CEA66608AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-sp8d2r6y7t0xtl****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyTags> Tags { get; set; }
        public class GetListenerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with <c>acs: </c>or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The timeout period of an idle TCP connection. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>350</para>
        /// </summary>
        [NameInMap("TcpIdleTimeout")]
        [Validation(Required=false)]
        public int? TcpIdleTimeout { get; set; }

    }

}
