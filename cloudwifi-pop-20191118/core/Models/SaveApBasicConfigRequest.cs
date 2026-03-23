// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SaveApBasicConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("Dai")]
        [Validation(Required=false)]
        public string Dai { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EchoInt")]
        [Validation(Required=false)]
        public int? EchoInt { get; set; }

        [NameInMap("Failover")]
        [Validation(Required=false)]
        public int? Failover { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InsecureAllowed")]
        [Validation(Required=false)]
        public int? InsecureAllowed { get; set; }

        [NameInMap("LanIp")]
        [Validation(Required=false)]
        public string LanIp { get; set; }

        [NameInMap("LanMask")]
        [Validation(Required=false)]
        public string LanMask { get; set; }

        [NameInMap("LanStatus")]
        [Validation(Required=false)]
        public int? LanStatus { get; set; }

        [NameInMap("LogIp")]
        [Validation(Required=false)]
        public string LogIp { get; set; }

        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public int? LogLevel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Passwd")]
        [Validation(Required=false)]
        public string Passwd { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("Route")]
        [Validation(Required=false)]
        public string Route { get; set; }

        [NameInMap("Scan")]
        [Validation(Required=false)]
        public int? Scan { get; set; }

        [NameInMap("TokenServer")]
        [Validation(Required=false)]
        public string TokenServer { get; set; }

        [NameInMap("Vpn")]
        [Validation(Required=false)]
        public string Vpn { get; set; }

        [NameInMap("WorkMode")]
        [Validation(Required=false)]
        public int? WorkMode { get; set; }

    }

}
