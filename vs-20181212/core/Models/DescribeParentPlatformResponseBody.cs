// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeParentPlatformResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ClientAuth")]
        [Validation(Required=false)]
        public bool? ClientAuth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31010*****317542006</para>
        /// </summary>
        [NameInMap("ClientGbId")]
        [Validation(Required=false)]
        public string ClientGbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin123</para>
        /// </summary>
        [NameInMap("ClientPassword")]
        [Validation(Required=false)]
        public string ClientPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5160</para>
        /// </summary>
        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public long? ClientPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("ClientUsername")]
        [Validation(Required=false)]
        public string ClientUsername { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31000*****2170123451</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>359*****374-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
