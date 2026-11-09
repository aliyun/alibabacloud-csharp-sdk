// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetMqttTicketRequest : TeaModel {
        /// <summary>
        /// <para>The client operating system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows 10</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <para>The client type. Valid values: 0: hardware terminal; 1: Windows software terminal; 2: macOS software terminal; 3: iOS client; 4: Android client; 5: web client; 6: tenant console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// <para>The client version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The extended properties of the client, represented as a JSON object where both keys and values are strings. Example: <c>{&quot;a&quot;:&quot;1&quot;,&quot;b&quot;:&quot;2&quot;}</c>. If this parameter is not specified, it is processed as an empty property set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;a&quot;:&quot;1&quot;,&quot;b&quot;:&quot;2&quot;}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The device UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
