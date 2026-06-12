// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ESIngestionConfigurationSource : TeaModel {
        /// <summary>
        /// <para>The URL of the service instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BootstrapServers")]
        [Validation(Required=false)]
        public string BootstrapServers { get; set; }

        /// <summary>
        /// <para>The import mode.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConnectorMode")]
        [Validation(Required=false)]
        public string ConnectorMode { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of ES indexes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public string Index { get; set; }

        /// <summary>
        /// <para>The maximum data delay in seconds.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MaxDataDelaySec")]
        [Validation(Required=false)]
        public long? MaxDataDelaySec { get; set; }

        /// <summary>
        /// <para>The interval in seconds for checking new data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MinFragRangeSec")]
        [Validation(Required=false)]
        public long? MinFragRangeSec { get; set; }

        /// <summary>
        /// <para>The password for the ES user.</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ES query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The time field.</para>
        /// </summary>
        [NameInMap("TimeFieldName")]
        [Validation(Required=false)]
        public string TimeFieldName { get; set; }

        /// <summary>
        /// <para>The format of the time field.</para>
        /// </summary>
        [NameInMap("TimeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <para>The time zone of the time field.</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>The username for ES.</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the VPC instance.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
