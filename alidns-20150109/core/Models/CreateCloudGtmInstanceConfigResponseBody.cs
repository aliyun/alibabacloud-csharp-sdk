// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the domain name instance configuration. A GTM instance can have both an A record and an AAAA record for the same access domain name. In this case, the GTM instance has two domain name instance configurations. The ConfigId uniquely identifies each configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>config-000**1</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public bool? ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
